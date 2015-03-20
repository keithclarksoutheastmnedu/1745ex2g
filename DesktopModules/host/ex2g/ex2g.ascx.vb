#Region "Copyright"

' 
' Copyright (c) 2015
' by host
' 

#End Region

#Region "Using Statements"

Imports System
Imports DotNetNuke.Entities.Modules

#End Region

Namespace host.ex2g

    Partial Public Class ex2g
        Inherits PortalModuleBase

#Region "Event Handlers"
dim name as String = ""
        Protected Overrides Sub OnInit(e As EventArgs)
            MyBase.OnInit(e)
        End Sub

        Protected Overrides Sub OnLoad(e As EventArgs)
            MyBase.OnLoad(e)

            If Not Page.IsPostBack Then

            End If
        End Sub

        

#End Region

        Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            ' adds the text field strings and prints to a label
            Dim str As String = TextBox1.Text & " " & TextBox2.Text
            Label3.Text = str
        End Sub

        Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            TextBox1.Text = ""
            TextBox2.Text = ""
            Label3.Text = ""
        End Sub
    End Class

End Namespace


