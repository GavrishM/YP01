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
            this.UsersToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SignInToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.UserToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.SignOutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ProductsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CategoryToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SuppliersToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.StorageMethodsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.OptionsForSellingToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.MainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductsToolStripButton,
            this.CategoryToolStripButton,
            this.SuppliersToolStripButton,
            this.StorageMethodsToolStripButton,
            this.OptionsForSellingToolStripButton,
            this.SignOutToolStripButton,
            this.SignInToolStripButton,
            this.UsersToolStripButton,
            this.UserToolStripLabel});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(800, 25);
            this.MainToolStrip.TabIndex = 0;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // UsersToolStripButton
            // 
            this.UsersToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.UsersToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UsersToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("UsersToolStripButton.Image")));
            this.UsersToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UsersToolStripButton.Name = "UsersToolStripButton";
            this.UsersToolStripButton.Size = new System.Drawing.Size(89, 22);
            this.UsersToolStripButton.Text = "Пользователи";
            this.UsersToolStripButton.ToolTipText = "Пользователи";
            this.UsersToolStripButton.Click += new System.EventHandler(this.UsersToolStripButton_Click);
            // 
            // SignInToolStripButton
            // 
            this.SignInToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SignInToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SignInToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SignInToolStripButton.Image")));
            this.SignInToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SignInToolStripButton.Name = "SignInToolStripButton";
            this.SignInToolStripButton.Size = new System.Drawing.Size(44, 22);
            this.SignInToolStripButton.Text = "Войти";
            this.SignInToolStripButton.ToolTipText = "Sign in";
            // 
            // UserToolStripLabel
            // 
            this.UserToolStripLabel.Name = "UserToolStripLabel";
            this.UserToolStripLabel.Size = new System.Drawing.Size(0, 22);
            // 
            // SignOutToolStripButton
            // 
            this.SignOutToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SignOutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SignOutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SignOutToolStripButton.Image")));
            this.SignOutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SignOutToolStripButton.Name = "SignOutToolStripButton";
            this.SignOutToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.SignOutToolStripButton.Text = "Выход";
            // 
            // ProductsToolStripButton
            // 
            this.ProductsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ProductsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ProductsToolStripButton.Image")));
            this.ProductsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ProductsToolStripButton.Name = "ProductsToolStripButton";
            this.ProductsToolStripButton.Size = new System.Drawing.Size(52, 22);
            this.ProductsToolStripButton.Text = "Товары";
            // 
            // CategoryToolStripButton
            // 
            this.CategoryToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CategoryToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("CategoryToolStripButton.Image")));
            this.CategoryToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CategoryToolStripButton.Name = "CategoryToolStripButton";
            this.CategoryToolStripButton.Size = new System.Drawing.Size(68, 22);
            this.CategoryToolStripButton.Text = "Категории";
            this.CategoryToolStripButton.ToolTipText = "Категории";
            // 
            // SuppliersToolStripButton
            // 
            this.SuppliersToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SuppliersToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SuppliersToolStripButton.Image")));
            this.SuppliersToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SuppliersToolStripButton.Name = "SuppliersToolStripButton";
            this.SuppliersToolStripButton.Size = new System.Drawing.Size(81, 22);
            this.SuppliersToolStripButton.Text = "Поставщики";
            this.SuppliersToolStripButton.ToolTipText = "Поставщики";
            // 
            // StorageMethodsToolStripButton
            // 
            this.StorageMethodsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StorageMethodsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("StorageMethodsToolStripButton.Image")));
            this.StorageMethodsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StorageMethodsToolStripButton.Name = "StorageMethodsToolStripButton";
            this.StorageMethodsToolStripButton.Size = new System.Drawing.Size(117, 22);
            this.StorageMethodsToolStripButton.Text = "Способы хранения";
            this.StorageMethodsToolStripButton.ToolTipText = "Способы хранения";
            // 
            // OptionsForSellingToolStripButton
            // 
            this.OptionsForSellingToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OptionsForSellingToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("OptionsForSellingToolStripButton.Image")));
            this.OptionsForSellingToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OptionsForSellingToolStripButton.Name = "OptionsForSellingToolStripButton";
            this.OptionsForSellingToolStripButton.Size = new System.Drawing.Size(101, 22);
            this.OptionsForSellingToolStripButton.Text = "Варианты сбыта";
            this.OptionsForSellingToolStripButton.ToolTipText = "Варианты сбыта";
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
        private System.Windows.Forms.ToolStripButton UsersToolStripButton;
        private System.Windows.Forms.ToolStripLabel UserToolStripLabel;
        private System.Windows.Forms.ToolStripButton ProductsToolStripButton;
        private System.Windows.Forms.ToolStripButton CategoryToolStripButton;
        private System.Windows.Forms.ToolStripButton SuppliersToolStripButton;
        private System.Windows.Forms.ToolStripButton StorageMethodsToolStripButton;
        private System.Windows.Forms.ToolStripButton OptionsForSellingToolStripButton;
    }
}

