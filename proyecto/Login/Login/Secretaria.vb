Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class Secretaria
    Dim con As New SqlConnection(My.Settings.conexion)
    Dim mensaje, sentencia As String

    Sub EjecutarSql(ByVal sql As String, ByVal msg As String)
        Try
            Dim cmd As New SqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn2_insertar_Click(sender As Object, e As EventArgs) Handles btn2_insertar.Click
        sentencia = "INSERT INTO Usuarios VALUES ('" + txt2_usuario.Text + "','" + txt_contra.Text + "','" + cb_roll.Text + "') "
        mensaje = "Dato Insertados Correctamente"
        EjecutarSql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("Select *From Usuarios", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.dgv_usuario.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn2_buscar_Click(sender As Object, e As EventArgs) Handles btn2_buscar.Click
        Dim da As New SqlDataAdapter("SELECT * FROM Usuarios WHERE Nombre='" + txt2_usuario.Text + "'", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.dgv_usuario.DataSource = ds.Tables(0)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btn2_mostrar_Click(sender As Object, e As EventArgs) Handles btn2_mostrar.Click
        Try
            Dim da As New SqlDataAdapter("Select *From Usuarios", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.dgv_usuario.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class