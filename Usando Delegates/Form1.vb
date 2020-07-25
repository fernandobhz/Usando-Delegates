Public Class Form1
    Inherits FormularioCrud

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Registrar(Me, AddressOf Ola)
    End Sub

    Sub Ola()
        MsgBox("Olá")
    End Sub


End Class


Public Class FormularioCrud
    Inherits Form

    Private Filho As Form

    Delegate Sub S1()

    Sub Registrar(filho As Form, s1 As S1)
        Me.Filho = filho

        s1.Invoke()
    End Sub

End Class
