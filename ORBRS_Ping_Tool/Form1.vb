Imports System.IO

Public Class Form1
    Dim dtAdr As New DataTable
    Dim busy As Boolean = False
    Dim swLog As StreamWriter

    Private Sub DataInt()
        dtAdr = New DataTable
        dtAdr.Columns.Add("Name", GetType(String))
        dtAdr.Columns.Add("Adr", GetType(String))
        dtAdr.Columns.Add("St", GetType(String))
        dtAdr.Columns.Add("Delay", GetType(String))
        dtAdr.Columns.Add("ErrTime", GetType(String))
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1 Then
            MessageBox.Show("当前应用程序不允许重复运行多个实例！", "禁止运行", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
            Exit Sub
        End If
        DataInt()
        dgv.DataSource = dtAdr
        dgv.Columns(0).HeaderText = "名称"
        dgv.Columns(1).HeaderText = "地址"
        dgv.Columns(2).HeaderText = "状态"
        dgv.Columns(3).HeaderText = "延迟"
        dgv.Columns(4).HeaderText = "故障时间"
        dgv.Columns(4).Width = 200
        'Call btnOpen_Click(btnOpen, Nothing)
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        chkPoll.Checked = False
        busy = True
        Try
            Dim ofd As New OpenFileDialog
            With ofd
                .Title = "打开文件"
                .Filter = "CSV文件(*.csv)|*.csv|所有文件(*.*)|*.*"
                .FilterIndex = 1
                .InitialDirectory = Application.StartupPath
            End With
            If ofd.ShowDialog() = DialogResult.OK Then
                Dim fp As String = ofd.FileName
                dtAdr.Clear()
                Dim sr As New StreamReader(fp, System.Text.Encoding.GetEncoding("GB2312"))
                sr.ReadLine()
                Do Until sr.EndOfStream
                    Dim l As String = sr.ReadLine
                    Dim dr() As String = l.Split(","c)
                    dtAdr.Rows.Add(dr)
                Loop
                dgv.DataSource = dtAdr
                Dim logfp As String = fp.Substring(0, fp.LastIndexOf("."c) + 1) & "log"
                swLog = New StreamWriter(logfp, True, System.Text.Encoding.GetEncoding("GB2312"))
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        Finally
            busy = False
        End Try
    End Sub

    Private Sub btnStart_Click(sender As Button, e As EventArgs) Handles btnStart.Click
        sender.Enabled = False
        btnOpen.Enabled = False
        pbPoll.Value = 0
        busy = True
        Dim p As New Net.NetworkInformation.Ping
        For i = 0 To dtAdr.Rows.Count - 1
            Dim LogT As String = vbNullString
            Try
                Dim pr As Net.NetworkInformation.PingReply = p.Send(dtAdr(i)(1), 200)
                If pr.Status = Net.NetworkInformation.IPStatus.Success Then
                    dtAdr(i)(3) = $"{pr.RoundtripTime}ms"
                    If IsDBNull(dtAdr(i)(2)) Then WriteLog(i, "连接成功")
                    dtAdr(i)(2) = "正常"
                    If Not IsDBNull(dtAdr(i)(4)) Then '上一次有故障
                        dtAdr(i)(4) = vbNullString
                        WriteLog(i, "恢复正常")
                    End If
                Else
                    dtAdr(i)(2) = "故障"
                    dtAdr(i)(3) = pr.Status
                    If IsDBNull(dtAdr(i)(4)) Then
                        dtAdr(i)(4) = Format(Now(), "yyyy-MM-dd HH:mm:ss")
                        WriteLog(i, "故障")
                    End If
                End If
                dgv.CurrentCell = dgv.Rows(i).Cells(0)
            Catch ex As Exception
                dtAdr(i)(2) = "未知故障"
                dtAdr(i)(3) = ex.Message
                If IsDBNull(dtAdr(i)(4)) Then
                    dtAdr(i)(4) = Format(Now(), "yyyy-MM-dd HH:mm:ss")
                End If
            Finally
                dgv.Refresh()
                busy = False
            End Try
        Next
        sender.Enabled = True
        btnOpen.Enabled = True
    End Sub

    Private Sub WriteLog(ByVal idx As Integer, ByVal msg As String)
        Dim log As String = vbNullString
        log = $"{Format(Now(), "yyyy-MM-dd HH:mm:ss")},{dtAdr(idx)(1)},{msg},{dtAdr(idx)(3)}"
        swLog.WriteLine(log)
        swLog.Flush()
    End Sub

    Private Sub tmTime_Tick(sender As Object, e As EventArgs) Handles tmTime.Tick
        lbTime.Text = Now
    End Sub

    Private Sub chkPoll_CheckedChanged(sender As CheckBox, e As EventArgs) Handles chkPoll.CheckedChanged
        If numPoll.Value = 0 Then Exit Sub
        numPoll.Enabled = Not sender.Checked
        tmPoll.Enabled = sender.Checked
        pbPoll.Maximum = numPoll.Value
        pbPoll.Value = 0

    End Sub

    Private Sub tmPoll_Tick(sender As Object, e As EventArgs) Handles tmPoll.Tick
        If Not busy Then pbPoll.Value += 1
        If pbPoll.Value >= pbPoll.Maximum Then
            pbPoll.Value = 0
            If Not busy Then
                Call btnStart_Click(btnStart, Nothing)
            End If
        End If
    End Sub

End Class