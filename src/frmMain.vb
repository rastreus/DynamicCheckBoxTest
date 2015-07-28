#If False Then
Copyright © 2015 Russell Dillin

This file is part of DynamicCheckBoxTest.

DynamicCheckBoxTest is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

DynamicCheckBoxTest is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with DynamicCheckBoxTest. If not, see <http://www.gnu.org/licenses/>.
#End If

Imports System.Windows.Forms

''' <summary>
''' An Exercise in Dynamically
''' creating and deleting CheckBox.
''' </summary>
''' <remarks>
''' Russell Dillin
''' 07/28/2015
''' </remarks>
Public Class frmMain
	Private listOfCheckBox As List(Of CheckBox)
	Private Const CB_SPACE As Integer = 23
	Private Const NUM_OF_CB As Integer = 7
	Private Const START_LOC As Integer = 3
	Private HLT_FORE As Color = Color.Black
	Private HLT_BACK As Color = Color.Yellow
	Private REG_FORE As Color = Color.White
	Private REG_BACK As Color = Color.Transparent
	Private ALL_SLCT As Boolean = False

	Private Sub frmMain_Load(sender As Object, _
							 e As EventArgs) _
		Handles Me.Load
		listOfCheckBox = New List(Of CheckBox)
	End Sub

	Private Sub pnlMain_ControlAdded(sender As Object, _
									 e As EventArgs) _
		Handles pnlMain.ControlAdded
		Dim num As Integer = Me.listOfCheckBox.Count
		checkToDisableBtnCreate(num)
		checkToEnableSelectAll()
	End Sub

	Private Sub checkToEnableSelectAll()
		If Me.cbSelectAll.Enabled = False Then
			Me.cbSelectAll.Enabled = True
			Me.cbSelectAll.Visible = True
		End If
	End Sub

	Private Sub cbSelectAll_CheckedChanged(sender As Object, _
										   e As EventArgs) _
		Handles cbSelectAll.CheckedChanged
		ALL_SLCT = Me.cbSelectAll.Checked
		For Each cb As CheckBox In Me.pnlMain.Controls
			cb.Checked = ALL_SLCT
		Next
	End Sub

	Private Sub checkAllSelectAll()
		Dim bool As Boolean = False
		For Each cb As CheckBox In Me.pnlMain.Controls
			If cb.Checked = False Then
				bool = True
			End If
		Next
		If bool Then
			Me.cbSelectAll.CheckState = _
				CheckState.Indeterminate
		End If
	End Sub

	Private Sub relocateCheckBox()
		Dim pt As Point
		Dim curr As Integer = 0
		Dim prev As Integer = 0
		Dim diff As Integer = 0
		If Me.listOfCheckBox.Count >= 2 Then
			For Each cb As CheckBox In Me.pnlMain.Controls
				curr = cb.Location.Y
				diff = curr - prev
				If diff > CB_SPACE Then
					pt = cb.Location
					pt.Y -= CB_SPACE
					cb.Location = pt
					curr = cb.Location.Y
				End If
				prev = curr
			Next
		Else
			For Each cb As CheckBox In Me.pnlMain.Controls
				cb.Location = New Point(START_LOC, START_LOC)
			Next
		End If
	End Sub

	Private Sub renumberCheckBox()
		Dim num As Integer = 1
		For Each cb As CheckBox In Me.pnlMain.Controls
			cb.Text = "CheckBox " & num.ToString
			num += 1
		Next
	End Sub

	Private Sub checkToEnableBtnCreate(ByVal num As Integer)
		If (Me.btnCreate.Enabled = False And _
			num < NUM_OF_CB) Then
			Me.btnCreate.Text = "Create"
			Me.btnCreate.Enabled = True
		End If
	End Sub

	Private Sub checkToDisableBtnCreate(ByVal num As Integer)
		If Me.btnCreate.Enabled = True And num = NUM_OF_CB Then
			Me.btnCreate.Enabled = False
			Me.btnCreate.Text = String.Empty
		End If
	End Sub

	Private Sub checkToRelocateAndRenumberCheckBox()
		If (Me.cbSelectAll.Checked <> True) Or _
		   (Me.cbSelectAll.Checked And _
		   (Me.cbSelectAll.CheckState = _
			   CheckState.Indeterminate)) Then
			relocateCheckBox()
			renumberCheckBox()
			If Me.cbSelectAll.CheckState = _
				CheckState.Indeterminate Then
				Me.cbSelectAll.CheckState = _
					CheckState.Unchecked
			End If
		End If
	End Sub

	Private Sub checkToChangeBtnDeleteAndSelectAll(ByVal num As Integer)
		If num = 0 Then
			If Me.btnDelete.Enabled = True Then
				Me.btnDelete.Enabled = False
				Me.btnDelete.Text = String.Empty
			End If
			If Me.cbSelectAll.Enabled = True Then
				Me.cbSelectAll.Enabled = False
				Me.cbSelectAll.Visible = False
				Me.cbSelectAll.Checked = False
			End If
		End If
	End Sub

	Private Sub pnlMain_ControlRemoved(sender As Object, _
									   e As EventArgs) _
		Handles pnlMain.ControlRemoved
		Dim num As Integer = Me.listOfCheckBox.Count
		checkToEnableBtnCreate(num)
		checkToRelocateAndRenumberCheckBox()
		checkToChangeBtnDeleteAndSelectAll(num)
	End Sub

	Private Sub cb_CheckedChanged(sender As CheckBox, _
							  e As EventArgs)
		If sender.Checked Then
			If Me.btnDelete.Enabled = False Then
				Me.btnDelete.Text = "Delete"
				Me.btnDelete.Enabled = True
			End If
			sender.ForeColor = HLT_FORE
			sender.BackColor = HLT_BACK
		Else
			sender.ForeColor = REG_FORE
			sender.BackColor = REG_BACK
			If ALL_SLCT Then
				checkAllSelectAll()
			End If
		End If
	End Sub

	Private Function getCheckBox() As CheckBox
		Dim num As Integer = Me.listOfCheckBox.Count
		Dim cb As CheckBox = New CheckBox()
		cb.AutoSize = True
		cb.Checked = False
		cb.Enabled = True
		If num = 0 Then
			cb.Location = New Point(START_LOC, START_LOC)
			cb.Text = "CheckBox " & (num + 1).ToString
		Else
			Dim lastCheckBox As CheckBox = Me.listOfCheckBox.Last
			Dim pt As Point = lastCheckBox.Location
			pt.Y += CB_SPACE
			cb.Location = pt
			Dim split As String() = lastCheckBox.Text.Split(" ")
			cb.Text = "CheckBox " & (Integer.Parse( _
										 split.ElementAt(1)) + 1).ToString
		End If
		AddHandler cb.CheckedChanged, AddressOf cb_CheckedChanged
		Return cb
	End Function

	Private Sub btnCreate_Click(sender As Object, _
								e As EventArgs) _
		Handles btnCreate.Click
		Dim cb As CheckBox = getCheckBox()
		Me.listOfCheckBox.Add(cb)
		Me.pnlMain.Controls.Add(cb)
	End Sub

	Private Sub btnDelete_Click(sender As Object, _
								e As EventArgs) _
		Handles btnDelete.Click
		Dim toBeDeleted As List(Of CheckBox) = _
			New List(Of CheckBox)
		For Each cb As CheckBox In Me.listOfCheckBox
			If cb.Checked Then
				toBeDeleted.Add(cb)
			End If
		Next
		For Each cb As CheckBox In toBeDeleted
			Me.listOfCheckBox.Remove(cb)
			Me.pnlMain.Controls.Remove(cb)
			cb.Dispose()
		Next
		Me.btnDelete.Enabled = False
		Me.btnDelete.Text = String.Empty
	End Sub
End Class
