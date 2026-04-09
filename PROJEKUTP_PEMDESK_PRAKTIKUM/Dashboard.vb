<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Header = New Panel()
        Body = New Panel()
        Footer = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        Competitor = New Panel()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Panel1 = New Panel()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        Panel2 = New Panel()
        Label3 = New Label()
        PictureBox3 = New PictureBox()
        Panel3 = New Panel()
        Label4 = New Label()
        PictureBox4 = New PictureBox()
        Body.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        Competitor.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Header
        ' 
        Header.Location = New Point(-6, 1)
        Header.Name = "Header"
        Header.Size = New Size(951, 109)
        Header.TabIndex = 0
        ' 
        ' Body
        ' 
        Body.Controls.Add(TableLayoutPanel1)
        Body.Location = New Point(-6, 107)
        Body.Name = "Body"
        Body.Size = New Size(951, 422)
        Body.TabIndex = 1
        ' 
        ' Footer
        ' 
        Footer.Location = New Point(-6, 526)
        Footer.Name = "Footer"
        Footer.Size = New Size(961, 59)
        Footer.TabIndex = 2
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 48.3383675F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 51.6616325F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 291F))
        TableLayoutPanel1.Controls.Add(Panel3, 0, 1)
        TableLayoutPanel1.Controls.Add(Panel2, 2, 0)
        TableLayoutPanel1.Controls.Add(Panel1, 1, 0)
        TableLayoutPanel1.Controls.Add(Competitor, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(951, 422)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Competitor
        ' 
        Competitor.Anchor = AnchorStyles.None
        Competitor.Controls.Add(Label1)
        Competitor.Controls.Add(PictureBox1)
        Competitor.Location = New Point(69, 20)
        Competitor.Name = "Competitor"
        Competitor.Size = New Size(181, 171)
        Competitor.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(30, 15)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(118, 107)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(30, 129)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 28)
        Label1.TabIndex = 1
        Label1.Text = "Competitor"
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Location = New Point(398, 20)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(181, 171)
        Panel1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(48, 129)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 28)
        Label2.TabIndex = 1
        Label2.Text = "KUMITE"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(30, 15)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(118, 107)
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.None
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Location = New Point(714, 20)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(181, 171)
        Panel2.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(44, 125)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 28)
        Label3.TabIndex = 1
        Label3.Text = "KUMITE"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Location = New Point(30, 15)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(118, 107)
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.None
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(PictureBox4)
        Panel3.Location = New Point(69, 231)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(181, 171)
        Panel3.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(30, 129)
        Label4.Name = "Label4"
        Label4.Size = New Size(119, 28)
        Label4.TabIndex = 1
        Label4.Text = "Competitor"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Location = New Point(30, 15)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(118, 107)
        PictureBox4.TabIndex = 0
        PictureBox4.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(943, 575)
        Controls.Add(Header)
        Controls.Add(Body)
        Controls.Add(Footer)
        Name = "Form1"
        Text = "Form1"
        Body.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        Competitor.ResumeLayout(False)
        Competitor.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Header As Panel
    Friend WithEvents Body As Panel
    Friend WithEvents Footer As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Competitor As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox

End Class
