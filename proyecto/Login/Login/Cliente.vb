Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class Cliente
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

    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim da As New SqlDataAdapter("Select *From inUsuarios", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.dtg_admin.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sentencia = "UPDATE inUsuarios SET Nombre_u='" + txt_nombre.Text + "',Apellido='" + txt_apellidos.Text + "',Usuario='" + txt_usuario.Text + "',Correo='" + txt_correo.Text + "' WHERE Id='" + txt_id.Text + "'"
        mensaje = "Dato Actualizados Correctamente"
        EjecutarSql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("Select *From inUsuarios", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.dtg_admin.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sentencia = "DELETE inUsuarios WHERE Id='" + txt_id.Text + "'"
        mensaje = "Dato Eliminados Correctamente"
        EjecutarSql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("Select *From inUsuarios", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.dtg_admin.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim da As New SqlDataAdapter("SELECT * FROM inUsuarios WHERE Id='" + txt_id.Text + "'", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.dtg_admin.DataSource = ds.Tables(0)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sentencia = "INSERT INTO inUsuarios VALUES ('" + txt_id.Text + "','" + txt_nombre.Text + "','" + txt_apellidos.Text + "','" + txt_usuario.Text + "','" + txt_correo.Text + "') "
        mensaje = "Dato Insertados Correctamente"
        EjecutarSql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("Select *From inUsuarios", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.dtg_admin.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class