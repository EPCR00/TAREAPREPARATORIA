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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.king = New System.Windows.Forms.RadioButton()
        Me.queen = New System.Windows.Forms.RadioButton()
        Me.matrimonial = New System.Windows.Forms.RadioButton()
        Me.imperial = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txthilocrudo = New System.Windows.Forms.TextBox()
        Me.txtseda = New System.Windows.Forms.TextBox()
        Me.txtalgodon = New System.Windows.Forms.TextBox()
        Me.txtlino = New System.Windows.Forms.TextBox()
        Me.hilocrudo = New System.Windows.Forms.CheckBox()
        Me.seda = New System.Windows.Forms.CheckBox()
        Me.algodon = New System.Windows.Forms.CheckBox()
        Me.lino = New System.Windows.Forms.CheckBox()
        Me.aceptar = New System.Windows.Forms.Button()
        Me.limpiar = New System.Windows.Forms.Button()
        Me.salir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.costo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.venta = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.totallino = New System.Windows.Forms.Label()
        Me.totalalgodon = New System.Windows.Forms.Label()
        Me.totalseda = New System.Windows.Forms.Label()
        Me.totalhilocrudo = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global._201902886_CUBRECAMAS.My.Resources.Resources.acuarelas
        Me.PictureBox1.Location = New System.Drawing.Point(-6, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(741, 545)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.king)
        Me.GroupBox1.Controls.Add(Me.queen)
        Me.GroupBox1.Controls.Add(Me.matrimonial)
        Me.GroupBox1.Controls.Add(Me.imperial)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(124, 132)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tamaño de Cama"
        '
        'king
        '
        Me.king.AutoSize = True
        Me.king.Location = New System.Drawing.Point(22, 95)
        Me.king.Name = "king"
        Me.king.Size = New System.Drawing.Size(46, 17)
        Me.king.TabIndex = 3
        Me.king.TabStop = True
        Me.king.Text = "King"
        Me.king.UseVisualStyleBackColor = True
        '
        'queen
        '
        Me.queen.AutoSize = True
        Me.queen.Location = New System.Drawing.Point(22, 72)
        Me.queen.Name = "queen"
        Me.queen.Size = New System.Drawing.Size(57, 17)
        Me.queen.TabIndex = 2
        Me.queen.TabStop = True
        Me.queen.Text = "Queen"
        Me.queen.UseVisualStyleBackColor = True
        '
        'matrimonial
        '
        Me.matrimonial.AutoSize = True
        Me.matrimonial.Location = New System.Drawing.Point(22, 49)
        Me.matrimonial.Name = "matrimonial"
        Me.matrimonial.Size = New System.Drawing.Size(78, 17)
        Me.matrimonial.TabIndex = 1
        Me.matrimonial.TabStop = True
        Me.matrimonial.Text = "Matrimonial"
        Me.matrimonial.UseVisualStyleBackColor = True
        '
        'imperial
        '
        Me.imperial.AutoSize = True
        Me.imperial.Location = New System.Drawing.Point(22, 26)
        Me.imperial.Name = "imperial"
        Me.imperial.Size = New System.Drawing.Size(61, 17)
        Me.imperial.TabIndex = 0
        Me.imperial.TabStop = True
        Me.imperial.Text = "Imperial"
        Me.imperial.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txthilocrudo)
        Me.GroupBox2.Controls.Add(Me.txtseda)
        Me.GroupBox2.Controls.Add(Me.txtalgodon)
        Me.GroupBox2.Controls.Add(Me.txtlino)
        Me.GroupBox2.Controls.Add(Me.hilocrudo)
        Me.GroupBox2.Controls.Add(Me.seda)
        Me.GroupBox2.Controls.Add(Me.algodon)
        Me.GroupBox2.Controls.Add(Me.lino)
        Me.GroupBox2.Location = New System.Drawing.Point(222, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(245, 132)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Material"
        '
        'txthilocrudo
        '
        Me.txthilocrudo.Enabled = False
        Me.txthilocrudo.Location = New System.Drawing.Point(120, 93)
        Me.txthilocrudo.Name = "txthilocrudo"
        Me.txthilocrudo.Size = New System.Drawing.Size(100, 20)
        Me.txthilocrudo.TabIndex = 7
        Me.txthilocrudo.Text = "0"
        '
        'txtseda
        '
        Me.txtseda.Enabled = False
        Me.txtseda.Location = New System.Drawing.Point(120, 71)
        Me.txtseda.Name = "txtseda"
        Me.txtseda.Size = New System.Drawing.Size(100, 20)
        Me.txtseda.TabIndex = 6
        Me.txtseda.Text = "0"
        '
        'txtalgodon
        '
        Me.txtalgodon.Enabled = False
        Me.txtalgodon.Location = New System.Drawing.Point(120, 46)
        Me.txtalgodon.Name = "txtalgodon"
        Me.txtalgodon.Size = New System.Drawing.Size(100, 20)
        Me.txtalgodon.TabIndex = 5
        Me.txtalgodon.Text = "0"
        '
        'txtlino
        '
        Me.txtlino.Enabled = False
        Me.txtlino.Location = New System.Drawing.Point(120, 23)
        Me.txtlino.Name = "txtlino"
        Me.txtlino.Size = New System.Drawing.Size(100, 20)
        Me.txtlino.TabIndex = 4
        Me.txtlino.Text = "0"
        '
        'hilocrudo
        '
        Me.hilocrudo.AutoSize = True
        Me.hilocrudo.Location = New System.Drawing.Point(25, 96)
        Me.hilocrudo.Name = "hilocrudo"
        Me.hilocrudo.Size = New System.Drawing.Size(75, 17)
        Me.hilocrudo.TabIndex = 3
        Me.hilocrudo.Text = "Hilo Crudo"
        Me.hilocrudo.UseVisualStyleBackColor = True
        '
        'seda
        '
        Me.seda.AutoSize = True
        Me.seda.Location = New System.Drawing.Point(25, 73)
        Me.seda.Name = "seda"
        Me.seda.Size = New System.Drawing.Size(51, 17)
        Me.seda.TabIndex = 2
        Me.seda.Text = "Seda"
        Me.seda.UseVisualStyleBackColor = True
        '
        'algodon
        '
        Me.algodon.AutoSize = True
        Me.algodon.Location = New System.Drawing.Point(25, 49)
        Me.algodon.Name = "algodon"
        Me.algodon.Size = New System.Drawing.Size(65, 17)
        Me.algodon.TabIndex = 1
        Me.algodon.Text = "Algodón"
        Me.algodon.UseVisualStyleBackColor = True
        '
        'lino
        '
        Me.lino.AutoSize = True
        Me.lino.Location = New System.Drawing.Point(25, 26)
        Me.lino.Name = "lino"
        Me.lino.Size = New System.Drawing.Size(46, 17)
        Me.lino.TabIndex = 0
        Me.lino.Text = "Lino"
        Me.lino.UseVisualStyleBackColor = True
        '
        'aceptar
        '
        Me.aceptar.Location = New System.Drawing.Point(565, 34)
        Me.aceptar.Name = "aceptar"
        Me.aceptar.Size = New System.Drawing.Size(90, 23)
        Me.aceptar.TabIndex = 3
        Me.aceptar.Text = "&Aceptar"
        Me.aceptar.UseVisualStyleBackColor = True
        '
        'limpiar
        '
        Me.limpiar.Location = New System.Drawing.Point(565, 77)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(90, 23)
        Me.limpiar.TabIndex = 4
        Me.limpiar.Text = "&Limpiar"
        Me.limpiar.UseVisualStyleBackColor = True
        '
        'salir
        '
        Me.salir.Location = New System.Drawing.Point(565, 123)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(90, 23)
        Me.salir.TabIndex = 5
        Me.salir.Text = "&Salir"
        Me.salir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(393, 238)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Precio de Costo:  Q"
        '
        'costo
        '
        Me.costo.AutoSize = True
        Me.costo.Location = New System.Drawing.Point(498, 238)
        Me.costo.Name = "costo"
        Me.costo.Size = New System.Drawing.Size(28, 13)
        Me.costo.TabIndex = 7
        Me.costo.Text = "0.00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(393, 265)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Precio de Venta:  Q"
        '
        'venta
        '
        Me.venta.AutoSize = True
        Me.venta.Location = New System.Drawing.Point(498, 265)
        Me.venta.Name = "venta"
        Me.venta.Size = New System.Drawing.Size(28, 13)
        Me.venta.TabIndex = 9
        Me.venta.Text = "0.00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Total por Lino:           Q"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Total por Algodón:     Q"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(55, 281)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Total por Seda:          Q"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(55, 314)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Total por Hilo Crudo:  Q"
        '
        'totallino
        '
        Me.totallino.AutoSize = True
        Me.totallino.Location = New System.Drawing.Point(179, 220)
        Me.totallino.Name = "totallino"
        Me.totallino.Size = New System.Drawing.Size(28, 13)
        Me.totallino.TabIndex = 14
        Me.totallino.Text = "0.00"
        '
        'totalalgodon
        '
        Me.totalalgodon.AutoSize = True
        Me.totalalgodon.Location = New System.Drawing.Point(179, 250)
        Me.totalalgodon.Name = "totalalgodon"
        Me.totalalgodon.Size = New System.Drawing.Size(28, 13)
        Me.totalalgodon.TabIndex = 15
        Me.totalalgodon.Text = "0.00"
        '
        'totalseda
        '
        Me.totalseda.AutoSize = True
        Me.totalseda.Location = New System.Drawing.Point(179, 281)
        Me.totalseda.Name = "totalseda"
        Me.totalseda.Size = New System.Drawing.Size(28, 13)
        Me.totalseda.TabIndex = 16
        Me.totalseda.Text = "0.00"
        '
        'totalhilocrudo
        '
        Me.totalhilocrudo.AutoSize = True
        Me.totalhilocrudo.Location = New System.Drawing.Point(179, 314)
        Me.totalhilocrudo.Name = "totalhilocrudo"
        Me.totalhilocrudo.Size = New System.Drawing.Size(28, 13)
        Me.totalhilocrudo.TabIndex = 17
        Me.totalhilocrudo.Text = "0.00"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 379)
        Me.Controls.Add(Me.totalhilocrudo)
        Me.Controls.Add(Me.totalseda)
        Me.Controls.Add(Me.totalalgodon)
        Me.Controls.Add(Me.totallino)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.venta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.costo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.limpiar)
        Me.Controls.Add(Me.aceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents king As RadioButton
    Friend WithEvents queen As RadioButton
    Friend WithEvents matrimonial As RadioButton
    Friend WithEvents imperial As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents hilocrudo As CheckBox
    Friend WithEvents seda As CheckBox
    Friend WithEvents algodon As CheckBox
    Friend WithEvents lino As CheckBox
    Friend WithEvents txthilocrudo As TextBox
    Friend WithEvents txtseda As TextBox
    Friend WithEvents txtalgodon As TextBox
    Friend WithEvents txtlino As TextBox
    Friend WithEvents aceptar As Button
    Friend WithEvents limpiar As Button
    Friend WithEvents salir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents costo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents venta As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents totallino As Label
    Friend WithEvents totalalgodon As Label
    Friend WithEvents totalseda As Label
    Friend WithEvents totalhilocrudo As Label
End Class
