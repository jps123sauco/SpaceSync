Imports Guna.UI2.WinForms

Public Class frm_Main
    Dim currentBtn As Guna2Button

    Public Sub activateBtn(clickBtn As Guna2Button)
        deactivateBtn()
        currentBtn = clickBtn
        currentBtn.FillColor = Color.FromArgb(38, 166, 154)
        currentBtn.ShadowDecoration.Enabled = True
        currentBtn.BorderColor = Color.Transparent
        currentBtn.BorderThickness = 0
    End Sub

    Public Sub deactivateBtn()
        If currentBtn IsNot Nothing Then
            currentBtn.FillColor = Color.Transparent
            currentBtn.ShadowDecoration.Enabled = False
            currentBtn.BorderColor = Color.FromArgb(38, 166, 154)
            currentBtn.BorderThickness = 2
        End If
    End Sub

    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        activateBtn(btn_Dashboard)
        tbctrl_section.SelectedTab = tbp_Dashboard
    End Sub
    Private Sub btn_Dashboard_Click(sender As Object, e As EventArgs) Handles btn_Dashboard.Click
        activateBtn(TryCast(sender, Guna2Button))
        tbctrl_section.SelectedTab = tbp_Dashboard
    End Sub

    Private Sub btn_Courses_Click(sender As Object, e As EventArgs) Handles btn_Courses.Click
        activateBtn(TryCast(sender, Guna2Button))
        tbctrl_section.SelectedTab = tbp_Courses
    End Sub

    Private Sub btn_Programs_Click(sender As Object, e As EventArgs) Handles btn_Programs.Click
        activateBtn(TryCast(sender, Guna2Button))
        tbctrl_section.SelectedTab = tbp_Programs
    End Sub

    Private Sub btn_Instructors_Click(sender As Object, e As EventArgs) Handles btn_Instructors.Click
        activateBtn(TryCast(sender, Guna2Button))
        tbctrl_section.SelectedTab = tbp_Instructors
    End Sub

    Private Sub btn_Rooms_Click(sender As Object, e As EventArgs) Handles btn_Rooms.Click
        activateBtn(TryCast(sender, Guna2Button))
        tbctrl_section.SelectedTab = tbp_Rooms
    End Sub

    Private Sub btn_Schedules_Click(sender As Object, e As EventArgs) Handles btn_Schedules.Click
        activateBtn(TryCast(sender, Guna2Button))
        tbctrl_section.SelectedTab = tbp_Schedules
    End Sub

    Private Sub btn_Print_Click(sender As Object, e As EventArgs) Handles btn_Print.Click
        activateBtn(TryCast(sender, Guna2Button))
        tbctrl_section.SelectedTab = tbp_Print
    End Sub

    Private Sub btn_Setting_Click(sender As Object, e As EventArgs) Handles btn_Setting.Click
        activateBtn(TryCast(sender, Guna2Button))
        tbctrl_section.SelectedTab = tbp_Setting
    End Sub


End Class
