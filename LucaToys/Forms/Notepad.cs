﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LucaToys.Controls;

namespace LucaToys.Forms
{
    public partial class Notepad : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private LucaToys.Pages.FileBarNotepad fileBar = new Pages.FileBarNotepad();
        private LucaToys.Pages.EditBarNotepad editBar = new Pages.EditBarNotepad();
        private LucaToys.Pages.ViewBarNotepad viewBar = new Pages.ViewBarNotepad();
        private LucaToys.Pages.FormatBarNotepad formatBar = new Pages.FormatBarNotepad();

        public Notepad()
        {
            InitializeComponent();
            this.panel3.Controls.Add(this.fileBar);
            this.panel3.Controls.Add(this.editBar);
            this.panel3.Controls.Add(this.viewBar);
            this.panel3.Controls.Add(this.formatBar);

            this.fileBar.Dock = DockStyle.Fill;
            this.editBar.Dock = DockStyle.Fill;
            this.viewBar.Dock = DockStyle.Fill;
            this.formatBar.Dock = DockStyle.Fill;

            LTMenuItem itemUndo = new LTMenuItem();
            LTMenuItem itemRedo = new LTMenuItem();
            LTMenuItem itemCut = new LTMenuItem();
            LTMenuItem itemCopy = new LTMenuItem();
            LTMenuItem itemPaste = new LTMenuItem();
            LTMenuItem itemSelectAll = new LTMenuItem();
            LTMenuItem itemSearchGoogle = new LTMenuItem();
            LTMenuItem itemDelete = new LTMenuItem();
            itemUndo.SymbolIcon = "";
            itemRedo.SymbolIcon = "";
            itemCut.SymbolIcon = "";
            itemCopy.SymbolIcon = "";
            itemPaste.SymbolIcon = "";
            itemSelectAll.SymbolIcon = "";
            itemSearchGoogle.SymbolIcon = "";
            itemDelete.SymbolIcon = "";
            itemUndo.Text = "Undo";
            itemRedo.Text = "Redo";
            itemCut.Text = "Cut";
            itemCopy.Text = "Copy";
            itemPaste.Text = "Paste";
            itemSelectAll.Text = "Select All";
            itemSearchGoogle.Text = "Search Text";
            itemDelete.Text = "Delete Text";
            this.ltSmallMenu1.Items.Add(itemUndo);
            this.ltSmallMenu1.Items.Add(itemRedo);
            this.ltSmallMenu1.Items.Add(itemCut);
            this.ltSmallMenu1.Items.Add(itemCopy);
            this.ltSmallMenu1.Items.Add(itemPaste);
            this.ltSmallMenu1.Items.Add(itemSelectAll);
            this.ltSmallMenu1.Items.Add(itemSearchGoogle);
            this.ltSmallMenu1.Items.Add(itemDelete);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Messages.CloseMessage closeMessage = new Messages.CloseMessage(this);
            closeMessage.ShowDialog();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                this.btnMaximize.Text = "";
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.btnMaximize.Text = "";
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.mouseDown == true)
            {
                this.Location = new Point(
                (this.Location.X - this.lastLocation.X) + e.X, (this.Location.Y - this.lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseDown = true;
            this.lastLocation = e.Location;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseDown = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton3.Checked)
                this.fileBar.BringToFront();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
                this.editBar.BringToFront();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton4.Checked)
                this.viewBar.BringToFront();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked)
                this.formatBar.BringToFront();
        }
    }
}
