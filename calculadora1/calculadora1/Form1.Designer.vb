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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.btnminimizar = New System.Windows.Forms.Button()
        Me.txtpantalla = New System.Windows.Forms.TextBox()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btndividir = New System.Windows.Forms.Button()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.btnsumar = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btnrestar = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btnmultiplicar = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.btnalcuadrado = New System.Windows.Forms.Button()
        Me.btnigual = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btncerrar)
        Me.Panel1.Controls.Add(Me.btnminimizar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(346, 56)
        Me.Panel1.TabIndex = 0
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btncerrar.Image = Global.calculadora1.My.Resources.Resources.Icono_cerrar_FN
        Me.btncerrar.Location = New System.Drawing.Point(266, 0)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(75, 56)
        Me.btncerrar.TabIndex = 2
        Me.btncerrar.UseVisualStyleBackColor = False
        '
        'btnminimizar
        '
        Me.btnminimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnminimizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnminimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnminimizar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnminimizar.Image = Global.calculadora1.My.Resources.Resources.Icono_Minimizar
        Me.btnminimizar.Location = New System.Drawing.Point(185, 0)
        Me.btnminimizar.Name = "btnminimizar"
        Me.btnminimizar.Size = New System.Drawing.Size(75, 55)
        Me.btnminimizar.TabIndex = 1
        Me.btnminimizar.UseVisualStyleBackColor = False
        '
        'txtpantalla
        '
        Me.txtpantalla.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpantalla.Location = New System.Drawing.Point(14, 82)
        Me.txtpantalla.Multiline = True
        Me.txtpantalla.Name = "txtpantalla"
        Me.txtpantalla.Size = New System.Drawing.Size(320, 64)
        Me.txtpantalla.TabIndex = 3
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlimpiar.Location = New System.Drawing.Point(12, 179)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(75, 49)
        Me.btnlimpiar.TabIndex = 4
        Me.btnlimpiar.Text = "C"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'btndividir
        '
        Me.btndividir.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndividir.Location = New System.Drawing.Point(255, 347)
        Me.btndividir.Name = "btndividir"
        Me.btndividir.Size = New System.Drawing.Size(75, 49)
        Me.btndividir.TabIndex = 6
        Me.btndividir.Text = "÷"
        Me.btndividir.UseVisualStyleBackColor = True
        '
        'Btn1
        '
        Me.Btn1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn1.Location = New System.Drawing.Point(12, 234)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(75, 50)
        Me.Btn1.TabIndex = 7
        Me.Btn1.Text = "1"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'btnsumar
        '
        Me.btnsumar.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsumar.Location = New System.Drawing.Point(255, 178)
        Me.btnsumar.Name = "btnsumar"
        Me.btnsumar.Size = New System.Drawing.Size(75, 50)
        Me.btnsumar.TabIndex = 8
        Me.btnsumar.Text = "+"
        Me.btnsumar.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(93, 234)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(75, 50)
        Me.btn2.TabIndex = 9
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(174, 234)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(75, 50)
        Me.btn3.TabIndex = 10
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btnrestar
        '
        Me.btnrestar.Font = New System.Drawing.Font("Arial Narrow", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrestar.Location = New System.Drawing.Point(255, 234)
        Me.btnrestar.Name = "btnrestar"
        Me.btnrestar.Size = New System.Drawing.Size(75, 50)
        Me.btnrestar.TabIndex = 11
        Me.btnrestar.Text = "-"
        Me.btnrestar.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(12, 290)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(75, 50)
        Me.btn4.TabIndex = 12
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(93, 290)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(75, 50)
        Me.btn5.TabIndex = 13
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Location = New System.Drawing.Point(174, 290)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(75, 50)
        Me.btn6.TabIndex = 14
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btnmultiplicar
        '
        Me.btnmultiplicar.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmultiplicar.Location = New System.Drawing.Point(255, 290)
        Me.btnmultiplicar.Name = "btnmultiplicar"
        Me.btnmultiplicar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnmultiplicar.Size = New System.Drawing.Size(75, 50)
        Me.btnmultiplicar.TabIndex = 15
        Me.btnmultiplicar.Text = "x"
        Me.btnmultiplicar.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Location = New System.Drawing.Point(14, 346)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(75, 50)
        Me.btn7.TabIndex = 16
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.Location = New System.Drawing.Point(93, 346)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(75, 50)
        Me.btn8.TabIndex = 17
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.Location = New System.Drawing.Point(175, 346)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(75, 50)
        Me.btn9.TabIndex = 18
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.Location = New System.Drawing.Point(14, 402)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(154, 50)
        Me.btn0.TabIndex = 19
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btnborrar
        '
        Me.btnborrar.Image = Global.calculadora1.My.Resources.Resources._1063910_arrow_arrow_left_border_left_stroke_icon__1_
        Me.btnborrar.Location = New System.Drawing.Point(93, 179)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(75, 49)
        Me.btnborrar.TabIndex = 5
        Me.btnborrar.UseVisualStyleBackColor = True
        '
        'btnalcuadrado
        '
        Me.btnalcuadrado.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnalcuadrado.Location = New System.Drawing.Point(174, 178)
        Me.btnalcuadrado.Name = "btnalcuadrado"
        Me.btnalcuadrado.Size = New System.Drawing.Size(75, 50)
        Me.btnalcuadrado.TabIndex = 20
        Me.btnalcuadrado.Text = "^2"
        Me.btnalcuadrado.UseVisualStyleBackColor = True
        '
        'btnigual
        '
        Me.btnigual.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnigual.Location = New System.Drawing.Point(255, 402)
        Me.btnigual.Name = "btnigual"
        Me.btnigual.Size = New System.Drawing.Size(75, 50)
        Me.btnigual.TabIndex = 21
        Me.btnigual.Text = "="
        Me.btnigual.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(174, 402)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 50)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(346, 479)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnigual)
        Me.Controls.Add(Me.btnalcuadrado)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btnmultiplicar)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btnrestar)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btnsumar)
        Me.Controls.Add(Me.Btn1)
        Me.Controls.Add(Me.btndividir)
        Me.Controls.Add(Me.btnborrar)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.txtpantalla)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btncerrar As Button
    Friend WithEvents btnminimizar As Button
    Friend WithEvents txtpantalla As TextBox
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents btnborrar As Button
    Friend WithEvents btndividir As Button
    Friend WithEvents Btn1 As Button
    Friend WithEvents btnsumar As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btnrestar As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btnmultiplicar As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btnalcuadrado As Button
    Friend WithEvents btnigual As Button
    Friend WithEvents Button1 As Button
End Class
