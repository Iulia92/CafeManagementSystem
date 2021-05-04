
namespace CafeManagementSystem
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI.Animation.Animation animation8 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogut = new System.Windows.Forms.LinkLabel();
            this.btnExit = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.btnRemove = new Guna.UI.WinForms.GunaButton();
            this.btnUpdate = new Guna.UI.WinForms.GunaButton();
            this.btnAddItems = new Guna.UI.WinForms.GunaButton();
            this.btnPlaceOrder = new Guna.UI.WinForms.GunaButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_RemoveItem1 = new CafeManagementSystem.AllUserControls.UC_RemoveItem();
            this.uC_UpdateItems1 = new CafeManagementSystem.AllUserControls.UC_UpdateItems();
            this.uC_PlaceOrder1 = new CafeManagementSystem.AllUserControls.UC_PlaceOrder();
            this.uC_AddItems1 = new CafeManagementSystem.AllUserControls.UC_AddItems();
            this.uC_Welcome1 = new CafeManagementSystem.AllUserControls.UC_Welcome();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse4 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse5 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse6 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaTransition1 = new Guna.UI.WinForms.GunaTransition(this.components);
            this.gunaElipse7 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.uC_RemoveItem2 = new CafeManagementSystem.AllUserControls.UC_RemoveItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnLogut);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAddItems);
            this.panel1.Controls.Add(this.btnPlaceOrder);
            this.gunaTransition1.SetDecoration(this.panel1, Guna.UI.Animation.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(12, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 514);
            this.panel1.TabIndex = 0;
            // 
            // btnLogut
            // 
            this.btnLogut.ActiveLinkColor = System.Drawing.Color.DarkOrchid;
            this.btnLogut.AutoSize = true;
            this.gunaTransition1.SetDecoration(this.btnLogut, Guna.UI.Animation.DecorationType.None);
            this.btnLogut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogut.LinkColor = System.Drawing.Color.White;
            this.btnLogut.Location = new System.Drawing.Point(65, 469);
            this.btnLogut.Name = "btnLogut";
            this.btnLogut.Size = new System.Drawing.Size(63, 18);
            this.btnLogut.TabIndex = 5;
            this.btnLogut.TabStop = true;
            this.btnLogut.Text = "LogOut";
            this.btnLogut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnLogut_LinkClicked);
            // 
            // btnExit
            // 
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnExit.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btnExit.BorderColor = System.Drawing.Color.Black;
            this.gunaTransition1.SetDecoration(this.btnExit, Guna.UI.Animation.DecorationType.None);
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = null;
            this.btnExit.ImageSize = new System.Drawing.Size(52, 52);
            this.btnExit.Location = new System.Drawing.Point(3, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnExit.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(32, 29);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.AnimationHoverSpeed = 0.07F;
            this.btnRemove.AnimationSpeed = 0.03F;
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnRemove.BorderColor = System.Drawing.Color.Black;
            this.gunaTransition1.SetDecoration(this.btnRemove, Guna.UI.Animation.DecorationType.None);
            this.btnRemove.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRemove.FocusedColor = System.Drawing.Color.Empty;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Image = null;
            this.btnRemove.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRemove.Location = new System.Drawing.Point(18, 221);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.OnHoverBaseColor = System.Drawing.Color.DarkOrchid;
            this.btnRemove.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRemove.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRemove.OnHoverImage = null;
            this.btnRemove.OnPressedColor = System.Drawing.Color.Black;
            this.btnRemove.Radius = 15;
            this.btnRemove.Size = new System.Drawing.Size(202, 41);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove Items";
            this.btnRemove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AnimationHoverSpeed = 0.07F;
            this.btnUpdate.AnimationSpeed = 0.03F;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.Black;
            this.gunaTransition1.SetDecoration(this.btnUpdate, Guna.UI.Animation.DecorationType.None);
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = null;
            this.btnUpdate.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdate.Location = new System.Drawing.Point(18, 161);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.DarkOrchid;
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Radius = 15;
            this.btnUpdate.Size = new System.Drawing.Size(202, 41);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update Items";
            this.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddItems
            // 
            this.btnAddItems.AnimationHoverSpeed = 0.07F;
            this.btnAddItems.AnimationSpeed = 0.03F;
            this.btnAddItems.BackColor = System.Drawing.Color.Transparent;
            this.btnAddItems.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnAddItems.BorderColor = System.Drawing.Color.Black;
            this.gunaTransition1.SetDecoration(this.btnAddItems, Guna.UI.Animation.DecorationType.None);
            this.btnAddItems.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddItems.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddItems.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItems.ForeColor = System.Drawing.Color.White;
            this.btnAddItems.Image = null;
            this.btnAddItems.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddItems.Location = new System.Drawing.Point(18, 99);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.OnHoverBaseColor = System.Drawing.Color.DarkOrchid;
            this.btnAddItems.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddItems.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddItems.OnHoverImage = null;
            this.btnAddItems.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddItems.Radius = 15;
            this.btnAddItems.Size = new System.Drawing.Size(202, 41);
            this.btnAddItems.TabIndex = 1;
            this.btnAddItems.Text = "Add Items";
            this.btnAddItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.AnimationHoverSpeed = 0.07F;
            this.btnPlaceOrder.AnimationSpeed = 0.03F;
            this.btnPlaceOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnPlaceOrder.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnPlaceOrder.BorderColor = System.Drawing.Color.Black;
            this.gunaTransition1.SetDecoration(this.btnPlaceOrder, Guna.UI.Animation.DecorationType.None);
            this.btnPlaceOrder.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPlaceOrder.FocusedColor = System.Drawing.Color.Empty;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.Image = null;
            this.btnPlaceOrder.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPlaceOrder.Location = new System.Drawing.Point(18, 40);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.OnHoverBaseColor = System.Drawing.Color.DarkOrchid;
            this.btnPlaceOrder.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPlaceOrder.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPlaceOrder.OnHoverImage = null;
            this.btnPlaceOrder.OnPressedColor = System.Drawing.Color.Black;
            this.btnPlaceOrder.Radius = 15;
            this.btnPlaceOrder.Size = new System.Drawing.Size(202, 41);
            this.btnPlaceOrder.TabIndex = 0;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.uC_RemoveItem2);
            this.panel2.Controls.Add(this.uC_RemoveItem1);
            this.panel2.Controls.Add(this.uC_UpdateItems1);
            this.panel2.Controls.Add(this.uC_PlaceOrder1);
            this.panel2.Controls.Add(this.uC_AddItems1);
            this.panel2.Controls.Add(this.uC_Welcome1);
            this.gunaTransition1.SetDecoration(this.panel2, Guna.UI.Animation.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(211, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 514);
            this.panel2.TabIndex = 1;
            // 
            // uC_RemoveItem1
            // 
            this.gunaTransition1.SetDecoration(this.uC_RemoveItem1, Guna.UI.Animation.DecorationType.None);
            this.uC_RemoveItem1.Location = new System.Drawing.Point(-761, 0);
            this.uC_RemoveItem1.Name = "uC_RemoveItem1";
            this.uC_RemoveItem1.Size = new System.Drawing.Size(781, 514);
            this.uC_RemoveItem1.TabIndex = 4;
            // 
            // uC_UpdateItems1
            // 
            this.gunaTransition1.SetDecoration(this.uC_UpdateItems1, Guna.UI.Animation.DecorationType.None);
            this.uC_UpdateItems1.Location = new System.Drawing.Point(0, 0);
            this.uC_UpdateItems1.Name = "uC_UpdateItems1";
            this.uC_UpdateItems1.Size = new System.Drawing.Size(781, 514);
            this.uC_UpdateItems1.TabIndex = 3;
            // 
            // uC_PlaceOrder1
            // 
            this.gunaTransition1.SetDecoration(this.uC_PlaceOrder1, Guna.UI.Animation.DecorationType.None);
            this.uC_PlaceOrder1.Location = new System.Drawing.Point(0, 0);
            this.uC_PlaceOrder1.Name = "uC_PlaceOrder1";
            this.uC_PlaceOrder1.Size = new System.Drawing.Size(781, 514);
            this.uC_PlaceOrder1.TabIndex = 2;
            // 
            // uC_AddItems1
            // 
            this.gunaTransition1.SetDecoration(this.uC_AddItems1, Guna.UI.Animation.DecorationType.None);
            this.uC_AddItems1.ForeColor = System.Drawing.Color.Black;
            this.uC_AddItems1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.uC_AddItems1.Location = new System.Drawing.Point(0, 3);
            this.uC_AddItems1.Name = "uC_AddItems1";
            this.uC_AddItems1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uC_AddItems1.Size = new System.Drawing.Size(781, 514);
            this.uC_AddItems1.TabIndex = 1;
            // 
            // uC_Welcome1
            // 
            this.gunaTransition1.SetDecoration(this.uC_Welcome1, Guna.UI.Animation.DecorationType.None);
            this.uC_Welcome1.Location = new System.Drawing.Point(7, 4);
            this.uC_Welcome1.Name = "uC_Welcome1";
            this.uC_Welcome1.Size = new System.Drawing.Size(781, 507);
            this.uC_Welcome1.TabIndex = 0;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 30;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 30;
            this.gunaElipse2.TargetControl = this.panel2;
            // 
            // gunaElipse4
            // 
            this.gunaElipse4.TargetControl = this.panel2;
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.TargetControl = this;
            // 
            // gunaElipse5
            // 
            this.gunaElipse5.Radius = 30;
            this.gunaElipse5.TargetControl = this.panel2;
            // 
            // gunaElipse6
            // 
            this.gunaElipse6.Radius = 30;
            this.gunaElipse6.TargetControl = this.panel2;
            // 
            // gunaTransition1
            // 
            this.gunaTransition1.AnimationType = Guna.UI.Animation.AnimationType.ScaleAndRotate;
            this.gunaTransition1.Cursor = null;
            animation8.AnimateOnlyDifferences = true;
            animation8.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.BlindCoeff")));
            animation8.LeafCoeff = 0F;
            animation8.MaxTime = 1F;
            animation8.MinTime = 0F;
            animation8.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicCoeff")));
            animation8.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicShift")));
            animation8.MosaicSize = 0;
            animation8.Padding = new System.Windows.Forms.Padding(30);
            animation8.RotateCoeff = 0.5F;
            animation8.RotateLimit = 0.2F;
            animation8.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.ScaleCoeff")));
            animation8.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.SlideCoeff")));
            animation8.TimeCoeff = 0F;
            animation8.TransparencyCoeff = 0F;
            this.gunaTransition1.DefaultAnimation = animation8;
            this.gunaTransition1.MaxAnimationTime = 3000;
            // 
            // gunaElipse7
            // 
            this.gunaElipse7.Radius = 30;
            this.gunaElipse7.TargetControl = this.panel2;
            // 
            // uC_RemoveItem2
            // 
            this.gunaTransition1.SetDecoration(this.uC_RemoveItem2, Guna.UI.Animation.DecorationType.None);
            this.uC_RemoveItem2.Location = new System.Drawing.Point(0, 0);
            this.uC_RemoveItem2.Name = "uC_RemoveItem2";
            this.uC_RemoveItem2.Size = new System.Drawing.Size(781, 514);
            this.uC_RemoveItem2.TabIndex = 5;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(1004, 534);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.gunaTransition1.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton btnPlaceOrder;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaGradientCircleButton btnExit;
        private Guna.UI.WinForms.GunaButton btnRemove;
        private Guna.UI.WinForms.GunaButton btnUpdate;
        private Guna.UI.WinForms.GunaButton btnAddItems;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private System.Windows.Forms.LinkLabel btnLogut;
        private Guna.UI.WinForms.GunaElipse gunaElipse4;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
        private AllUserControls.UC_Welcome uC_Welcome1;
        private Guna.UI.WinForms.GunaElipse gunaElipse5;
        private AllUserControls.UC_AddItems uC_AddItems1;
        private Guna.UI.WinForms.GunaElipse gunaElipse6;
        private AllUserControls.UC_PlaceOrder uC_PlaceOrder1;
        private Guna.UI.WinForms.GunaTransition gunaTransition1;
        private AllUserControls.UC_UpdateItems uC_UpdateItems1;
        private AllUserControls.UC_RemoveItem uC_RemoveItem1;
        private Guna.UI.WinForms.GunaElipse gunaElipse7;
        private AllUserControls.UC_RemoveItem uC_RemoveItem2;
    }
}