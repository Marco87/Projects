Imports System.ComponentModel

<DefaultProperty("Value"), DefaultBindingProperty("Value")> _
Public Class DateTimePickerEx
    Inherits System.Windows.Forms.DateTimePicker

    Public Event ValueChangedOnClick(ByVal sender As Object, ByVal e As EventArgs)

    Protected Overrides Sub OnValueChanged(ByVal eventargs As System.EventArgs)
        MyBase.OnValueChanged(eventargs)
        If Me.ShowUpDown Then
            If Not m_ValueChanged And Not m_KeyDown Then
                RaiseEvent ValueChangedOnClick(Me, New EventArgs)
            End If
            m_KeyDown = False
            m_ValueChanged = False
        End If
    End Sub

    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        MyBase.OnKeyDown(e)
        m_KeyDown = True
    End Sub

    Private m_KeyDown As Boolean
    Private m_ValueChanged As Boolean

    Shadows Property Value() As Date
        Get
            Return MyBase.Value
        End Get
        Set(ByVal value As Date)
            m_ValueChanged = True
            MyBase.Value = value
        End Set
    End Property


End Class
