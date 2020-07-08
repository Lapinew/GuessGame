<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipale
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtSaisie = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.gboProposition = New System.Windows.Forms.GroupBox()
        Me.btnTester = New System.Windows.Forms.Button()
        Me.gboEssais = New System.Windows.Forms.GroupBox()
        Me.lstPropo = New System.Windows.Forms.ListBox()
        Me.lblTitrePropo = New System.Windows.Forms.Label()
        Me.lblNbRestant = New System.Windows.Forms.Label()
        Me.lblRestants = New System.Windows.Forms.Label()
        Me.lblHisto = New System.Windows.Forms.Label()
        Me.lstHisto = New System.Windows.Forms.ListBox()
        Me.lblTitreMot = New System.Windows.Forms.Label()
        Me.lblMot = New System.Windows.Forms.Label()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.gboProposition.SuspendLayout()
        Me.gboEssais.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSaisie
        '
        Me.txtSaisie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSaisie.Location = New System.Drawing.Point(15, 19)
        Me.txtSaisie.Name = "txtSaisie"
        Me.txtSaisie.ShortcutsEnabled = False
        Me.txtSaisie.Size = New System.Drawing.Size(129, 20)
        Me.txtSaisie.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'gboProposition
        '
        Me.gboProposition.Controls.Add(Me.btnTester)
        Me.gboProposition.Controls.Add(Me.txtSaisie)
        Me.gboProposition.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gboProposition.Location = New System.Drawing.Point(75, 99)
        Me.gboProposition.Name = "gboProposition"
        Me.gboProposition.Size = New System.Drawing.Size(233, 53)
        Me.gboProposition.TabIndex = 2
        Me.gboProposition.TabStop = False
        Me.gboProposition.Text = "Proposition"
        '
        'btnTester
        '
        Me.btnTester.Enabled = False
        Me.btnTester.Location = New System.Drawing.Point(150, 16)
        Me.btnTester.Name = "btnTester"
        Me.btnTester.Size = New System.Drawing.Size(75, 23)
        Me.btnTester.TabIndex = 3
        Me.btnTester.Text = "Tester"
        Me.btnTester.UseVisualStyleBackColor = True
        '
        'gboEssais
        '
        Me.gboEssais.Controls.Add(Me.lstPropo)
        Me.gboEssais.Controls.Add(Me.lblTitrePropo)
        Me.gboEssais.Controls.Add(Me.lblNbRestant)
        Me.gboEssais.Controls.Add(Me.lblRestants)
        Me.gboEssais.Location = New System.Drawing.Point(75, 203)
        Me.gboEssais.Name = "gboEssais"
        Me.gboEssais.Size = New System.Drawing.Size(233, 185)
        Me.gboEssais.TabIndex = 3
        Me.gboEssais.TabStop = False
        Me.gboEssais.Text = "Essais"
        '
        'lstPropo
        '
        Me.lstPropo.FormattingEnabled = True
        Me.lstPropo.Location = New System.Drawing.Point(6, 70)
        Me.lstPropo.Name = "lstPropo"
        Me.lstPropo.Size = New System.Drawing.Size(219, 108)
        Me.lstPropo.TabIndex = 4
        '
        'lblTitrePropo
        '
        Me.lblTitrePropo.AutoSize = True
        Me.lblTitrePropo.Location = New System.Drawing.Point(6, 54)
        Me.lblTitrePropo.Name = "lblTitrePropo"
        Me.lblTitrePropo.Size = New System.Drawing.Size(70, 13)
        Me.lblTitrePropo.TabIndex = 4
        Me.lblTitrePropo.Text = "Propositions :"
        '
        'lblNbRestant
        '
        Me.lblNbRestant.AutoSize = True
        Me.lblNbRestant.Location = New System.Drawing.Point(67, 29)
        Me.lblNbRestant.Name = "lblNbRestant"
        Me.lblNbRestant.Size = New System.Drawing.Size(19, 13)
        Me.lblNbRestant.TabIndex = 4
        Me.lblNbRestant.Text = "nb"
        '
        'lblRestants
        '
        Me.lblRestants.AutoSize = True
        Me.lblRestants.Location = New System.Drawing.Point(6, 29)
        Me.lblRestants.Name = "lblRestants"
        Me.lblRestants.Size = New System.Drawing.Size(55, 13)
        Me.lblRestants.TabIndex = 4
        Me.lblRestants.Text = "Restants :"
        '
        'lblHisto
        '
        Me.lblHisto.AutoSize = True
        Me.lblHisto.Location = New System.Drawing.Point(553, 86)
        Me.lblHisto.Name = "lblHisto"
        Me.lblHisto.Size = New System.Drawing.Size(74, 13)
        Me.lblHisto.TabIndex = 4
        Me.lblHisto.Text = "HISTORIQUE"
        '
        'lstHisto
        '
        Me.lstHisto.FormattingEnabled = True
        Me.lstHisto.Location = New System.Drawing.Point(506, 115)
        Me.lstHisto.Name = "lstHisto"
        Me.lstHisto.Size = New System.Drawing.Size(175, 186)
        Me.lstHisto.TabIndex = 5
        '
        'lblTitreMot
        '
        Me.lblTitreMot.AutoSize = True
        Me.lblTitreMot.Location = New System.Drawing.Point(142, 20)
        Me.lblTitreMot.Name = "lblTitreMot"
        Me.lblTitreMot.Size = New System.Drawing.Size(85, 13)
        Me.lblTitreMot.TabIndex = 6
        Me.lblTitreMot.Text = "Mot à ordonner :"
        '
        'lblMot
        '
        Me.lblMot.AutoSize = True
        Me.lblMot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMot.Location = New System.Drawing.Point(157, 54)
        Me.lblMot.Name = "lblMot"
        Me.lblMot.Size = New System.Drawing.Size(51, 20)
        Me.lblMot.TabIndex = 7
        Me.lblMot.Text = "lblMot"
        '
        'btnRestart
        '
        Me.btnRestart.Location = New System.Drawing.Point(506, 358)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(75, 23)
        Me.btnRestart.TabIndex = 4
        Me.btnRestart.Text = "Rejouer"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(606, 358)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(75, 23)
        Me.btnQuitter.TabIndex = 8
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'FormPrincipale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.lblMot)
        Me.Controls.Add(Me.lblTitreMot)
        Me.Controls.Add(Me.lstHisto)
        Me.Controls.Add(Me.lblHisto)
        Me.Controls.Add(Me.gboEssais)
        Me.Controls.Add(Me.gboProposition)
        Me.Name = "FormPrincipale"
        Me.Text = "Jeu de mots"
        Me.gboProposition.ResumeLayout(False)
        Me.gboProposition.PerformLayout()
        Me.gboEssais.ResumeLayout(False)
        Me.gboEssais.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSaisie As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents gboProposition As GroupBox
    Friend WithEvents btnTester As Button
    Friend WithEvents gboEssais As GroupBox
    Friend WithEvents lblRestants As Label
    Friend WithEvents lstPropo As ListBox
    Friend WithEvents lblTitrePropo As Label
    Friend WithEvents lblNbRestant As Label
    Friend WithEvents lblHisto As Label
    Friend WithEvents lstHisto As ListBox
    Friend WithEvents lblTitreMot As Label
    Friend WithEvents lblMot As Label
    Friend WithEvents btnRestart As Button
    Friend WithEvents btnQuitter As Button
End Class
