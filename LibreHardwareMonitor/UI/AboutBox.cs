// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// Copyright (C) LibreHardwareMonitor and Contributors.
// Partial Copyright (C) Michael Möller <mmoeller@openhardwaremonitor.org> and Contributors.
// All Rights Reserved.

using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace LibreHardwareMonitor.UI;

public sealed partial class AboutBox : Form
{
    public AboutBox()
    {
        InitializeComponent();
        Font = SystemFonts.MessageBoxFont;
        label3.Text = "Version " + Application.ProductVersion;
        projectLinkLabel.Links.Remove(projectLinkLabel.Links[0]);
        projectLinkLabel.Links.Add(0, projectLinkLabel.Text.Length, "https://github.com/LibreHardwareMonitor/LibreHardwareMonitor");
        licenseLinkLabel.Links.Remove(licenseLinkLabel.Links[0]);
        licenseLinkLabel.Links.Add(0, licenseLinkLabel.Text.Length, "https://www.mozilla.org/en-US/MPL/2.0/");

        linkLabel1.Links.Remove(licenseLinkLabel.Links[0]);
        linkLabel1.Links.Add(0, licenseLinkLabel.Text.Length, "https://www.bilibili.com/");

    }

    private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        try
        {
            Process.Start(new ProcessStartInfo(e.Link.LinkData.ToString()));
        }
        catch { }
    }

    private void AboutBox_Load(object sender, System.EventArgs e)
    {

    }

    private void label1_Click(object sender, System.EventArgs e)
    {

    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        try
        {
            System.Diagnostics.Process.Start("https://www.bilibili.com/video/BV1XJ4m1G7mX/");
        }
        catch { }
    }

    private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {

    }

    private void label5_Click(object sender, System.EventArgs e)
    {

    }

    private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        try
        {
            System.Diagnostics.Process.Start("https://user.qzone.qq.com/2821981550");
        }
        catch { }
    }

    private void label6_Click(object sender, System.EventArgs e)
    {

    }
}
