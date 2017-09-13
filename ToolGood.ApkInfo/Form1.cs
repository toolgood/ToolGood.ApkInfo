using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ToolGood.ApkInfo.Codes;

namespace ToolGood.ApkInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "安桌安装包|*.apk";
            if (ofd.ShowDialog() == DialogResult.OK) {
                SetInfo(ofd.FileName);
            }
        }

        private void SetInfo(string apkPath)
        {
            tb_apkPath.Text = apkPath;

            var af = ApkFile.OpenFile(apkPath);
            tb_pgName.Text = af.ApkInfo.packageName;
            tb_md5.Text = af.GetThumbprintMd5();
            tb_sha1.Text = af.GetThumbprintSha1();
            tb_sha256.Text = af.GetThumbprintSha256();

            lb_list.Items.Clear();
            lb_list.Items.Add(string.Format("包名: {0}", af.ApkInfo.packageName));
            lb_list.Items.Add(string.Format("版本名: {0}", af.ApkInfo.versionName));
            lb_list.Items.Add(string.Format("版本编号: {0}", af.ApkInfo.versionCode));

            lb_list.Items.Add(string.Format("是否包含图标: {0}", af.ApkInfo.hasIcon));
            if (af.ApkInfo.iconFileName.Count > 0)
                lb_list.Items.Add(string.Format("App图标: {0}", af.ApkInfo.iconFileName[0]));
            lb_list.Items.Add(string.Format("最小SDK版本: {0}", af.ApkInfo.minSdkVersion));
            lb_list.Items.Add(string.Format("当前SDK版本: {0}", af.ApkInfo.targetSdkVersion));

            if (af.ApkInfo.Permissions != null && af.ApkInfo.Permissions.Count > 0) {
                lb_list.Items.Add("权限:");
                af.ApkInfo.Permissions.ForEach(f => {
                    lb_list.Items.Add(string.Format("   {0}", f));
                });
            } else
                lb_list.Items.Add("没有任何权限");

            lb_list.Items.Add(string.Format("支持任何屏幕: {0}", af.ApkInfo.supportAnyDensity));
            lb_list.Items.Add(string.Format("支持大屏: {0}", af.ApkInfo.supportLargeScreens));
            lb_list.Items.Add(string.Format("支持中屏: {0}", af.ApkInfo.supportNormalScreens));
            lb_list.Items.Add(string.Format("支持小屏: {0}", af.ApkInfo.supportSmallScreens));
            lb_list.Items.Add("签名信息：");

            lb_list.Items.Add(string.Format("所有者: {0}", af.Certificate.Issuer));
            lb_list.Items.Add(string.Format("发布者: {0}", af.Certificate.Subject));
            lb_list.Items.Add(string.Format("序列号: {0}", af.Certificate.SerialNumber));
            lb_list.Items.Add(string.Format("有效期开始时间: {0}", af.Certificate.GetEffectiveDateString()));
            lb_list.Items.Add(string.Format("有效期结束时间: {0}", af.Certificate.GetExpirationDateString()));
            lb_list.Items.Add("证书指纹：");
            lb_list.Items.Add(string.Format("    MD5: {0}", af.GetThumbprintMd5()));
            lb_list.Items.Add(string.Format("    SHA1: {0}", af.GetThumbprintSha1()));
            lb_list.Items.Add(string.Format("    SHA256: {0}", af.GetThumbprintSha256()));
            lb_list.Items.Add(string.Format("    算法: {0}", af.Certificate.SignatureAlgorithm.FriendlyName));
            lb_list.Items.Add(string.Format("    版本: {0}", af.Certificate.Version));



        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            Debug.WriteLine("Form1_DragEnter");

            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                var file = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
                var ext = Path.GetExtension(file).ToLower();
                if (ext == ".apk") {
                    e.Effect = DragDropEffects.Link;
                    return;
                }
            }
            e.Effect = DragDropEffects.None;

        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            var file = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            SetInfo(file);
        }


    }
}
