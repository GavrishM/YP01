namespace InventoryManagementSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.SignOutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SignInToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SignUpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.UserToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.MainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SignUpToolStripButton,
            this.SignInToolStripButton,
            this.UserToolStripLabel,
            this.SignOutToolStripButton});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(800, 25);
            this.MainToolStrip.TabIndex = 0;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // SignOutToolStripButton
            // 
            this.SignOutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SignOutToolStripButton.Image")));
            this.SignOutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SignOutToolStripButton.Name = "SignOutToolStripButton";
            this.SignOutToolStripButton.Size = new System.Drawing.Size(62, 22);
            this.SignOutToolStripButton.Text = "Выход";
            // 
            // SignInToolStripButton
            // 
            this.SignInToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SignInToolStripButton.Image")));
            this.SignInToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SignInToolStripButton.Name = "SignInToolStripButton";
            this.SignInToolStripButton.Size = new System.Drawing.Size(60, 22);
            this.SignInToolStripButton.Text = "Войти";
            this.SignInToolStripButton.ToolTipText = "Sign in";
            // 
            // SignUpToolStripButton
            // 
            this.SignUpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SignUpToolStripButton.Image")));
            this.SignUpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SignUpToolStripButton.Name = "SignUpToolStripButton";
            this.SignUpToolStripButton.Size = new System.Drawing.Size(139, 22);
            this.SignUpToolStripButton.Text = "Зарегистрироваться";
            // 
            // UserToolStripLabel
            // 
            this.UserToolStripLabel.Name = "UserToolStripLabel";
            this.UserToolStripLabel.Size = new System.Drawing.Size(0, 22);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainToolStrip);
            this.Name = "MainForm";
            this.Text = "Система учета товара";
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton SignInToolStripButton;
        private System.Windows.Forms.ToolStripButton SignOutToolStripButton;
        private System.Windows.Forms.ToolStripButton SignUpToolStripButton;
        private System.Windows.Forms.ToolStripLabel UserToolStripLabel;
    }
}

