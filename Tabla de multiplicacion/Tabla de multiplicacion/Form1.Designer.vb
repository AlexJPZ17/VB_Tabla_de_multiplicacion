<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button_run = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox_mostrar = New System.Windows.Forms.ListBox()
        Me.TextBox_tabla = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button_clean = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_run
        '
        Me.Button_run.Location = New System.Drawing.Point(42, 234)
        Me.Button_run.Name = "Button_run"
        Me.Button_run.Size = New System.Drawing.Size(75, 23)
        Me.Button_run.TabIndex = 0
        Me.Button_run.Text = "Run"
        Me.Button_run.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tlabla"
        '
        'ListBox_mostrar
        '
        Me.ListBox_mostrar.FormattingEnabled = True
        Me.ListBox_mostrar.Location = New System.Drawing.Point(140, 25)
        Me.ListBox_mostrar.Name = "ListBox_mostrar"
        Me.ListBox_mostrar.Size = New System.Drawing.Size(120, 186)
        Me.ListBox_mostrar.TabIndex = 2
        '
        'TextBox_tabla
        '
        Me.TextBox_tabla.Location = New System.Drawing.Point(23, 59)
        Me.TextBox_tabla.Name = "TextBox_tabla"
        Me.TextBox_tabla.Size = New System.Drawing.Size(68, 20)
        Me.TextBox_tabla.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button_clean)
        Me.GroupBox1.Controls.Add(Me.ListBox_mostrar)
        Me.GroupBox1.Controls.Add(Me.Button_run)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox_tabla)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(279, 263)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tabla de multiplicacion"
        '
        'Button_clean
        '
        Me.Button_clean.Location = New System.Drawing.Point(140, 234)
        Me.Button_clean.Name = "Button_clean"
        Me.Button_clean.Size = New System.Drawing.Size(75, 23)
        Me.Button_clean.TabIndex = 4
        Me.Button_clean.Text = "Clean"
        Me.Button_clean.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 297)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button_run As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBox_mostrar As System.Windows.Forms.ListBox
    Friend WithEvents TextBox_tabla As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button_clean As System.Windows.Forms.Button

End Class
