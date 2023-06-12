using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BussinessLayer;
using DataLayer;
using DevExpress.Utils.DirectXPaint;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using DevExpress.XtraNavBar;

namespace THUEPHONG
{
    public partial class MainView : DevExpress.XtraEditors.XtraForm
    {
        public MainView()
        {
            InitializeComponent();
            if (!mvvmContext1.IsDesignMode)
                InitializeBindings();
        }

        public MainView(tb_SYS_USER user)
        {
            InitializeComponent();
            this._user = user;
            this.Text = "PHẦN MỀM QUẢN LÝ KHÁCH SẠN - " + _user.FULLNAME;
        }
        tb_SYS_USER _user;
        void InitializeBindings()
        {
            var fluent = mvvmContext1.OfType<MainViewModel>();
        }

        FUNC _func;
        TANG _tang;
        PHONG _phong;
        SYS_GROUP _sysGroup;
        SYS_RIGHT _sysRight;
        GalleryItem item = null;
        private void MainView_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            _func = new FUNC();
            _tang = new TANG();
            _phong = new PHONG();
            _sysGroup = new SYS_GROUP();
            _sysRight = new SYS_RIGHT();
            leftMenu();
            showRoom();
        }

        void leftMenu()
        {
            var lsParent = _func.getParent();
            foreach(var _pr in lsParent)
            {
                NavBarGroup navgroup = new NavBarGroup(_pr.DECRIPTION);
                navgroup.Tag = _pr.FUNC_CODE;
                navgroup.Name = _pr.FUNC_CODE;
                navMain.Groups.Add(navgroup);

                var lsChild = _func.getChild(_pr.FUNC_CODE);
                foreach(var _ch in lsChild)
                {
                    NavBarItem navItem = new NavBarItem(_ch.DECRIPTION);
                    navItem.Tag = _ch.FUNC_CODE;
                    navItem.Name = _ch.FUNC_CODE;
                    navgroup.ItemLinks.Add(navItem);
                }
                navMain.Groups[navgroup.Name].Expanded = true;
            }
        }

        public void showRoom()
        {
            _tang = new TANG();
            _phong = new PHONG();
            var lsTang = _tang.getAll();
            gControl.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside;
            gControl.Gallery.ImageSize = new Size(64, 64);
            gControl.Gallery.ShowItemText = true;
            gControl.Gallery.ShowGroupCaption = true;
            foreach(var t in lsTang)
            {
                var galleryItem = new GalleryItemGroup();
                galleryItem.Caption = t.TENTANG;
                galleryItem.CaptionAlignment = GalleryItemGroupCaptionAlignment.Stretch;

                var lsPhong = _phong.getByTang(t.IDTANG);
                foreach(var p in lsPhong)
                {
                    var gc_Item = new GalleryItem();
                    gc_Item.Caption = p.TENPHONG;
                    gc_Item.Value = p.IDPHONG;
                    if(p.TRANGTHAI == true)
                    {
                        gc_Item.ImageOptions.Image = imageList1.Images[1];
                    }
                    else
                    {
                        gc_Item.ImageOptions.Image = imageList1.Images[0];
                    }
                    galleryItem.Items.Add(gc_Item);
                }
                gControl.Gallery.Groups.Add(galleryItem);
            }
        }
        private void btnHeThong_Click(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void navMain_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            string func_code = e.Link.Item.Tag.ToString();


            var _group = _sysGroup.getGroupByMemBer(_user.IDUSER);
            var _uRight = _sysRight.getRight(_user.IDUSER, func_code);

            if (_group != null)
            {
                var _groupRight = _sysRight.getRight(_group.GROUP, func_code);
                if (_uRight.USER_RIGHT < _groupRight.USER_RIGHT)
                    _uRight.USER_RIGHT = _groupRight.USER_RIGHT;
            }

            if (_uRight.USER_RIGHT == 0)
            {
                MessageBox.Show("Không có quyền thao tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                switch (func_code)
                {
                    case "CONGTY":
                        {
                            frmCongTy frm = new frmCongTy();
                            frm.ShowDialog();
                            break;
                        }
                    case "DONVI":
                        {
                            frmDonVi frm = new frmDonVi();
                            frm.ShowDialog();
                            break;
                        }
                    case "TANG":
                        {
                            frmTang frm = new frmTang();
                            frm.ShowDialog();
                            break;
                        }
                    case "LOAIPHONG":
                        {
                            frmLoaiPhong frm = new frmLoaiPhong();
                            frm.ShowDialog();
                            break;
                        }
                    case "PHONG":
                        {
                            frmPhong frm = new frmPhong();
                            frm.ShowDialog();
                            break;
                        }
                    case "SANPHAM":
                        {
                            frmSanPham frm = new frmSanPham();
                            frm.ShowDialog();
                            break;
                        }
                    case "THIETBI":
                        {
                            frmThietBi frm = new frmThietBi();
                            frm.ShowDialog();
                            break;
                        }
                    case "PHONG_THIETBI":
                        {
                            frmThietBiPhong frm = new frmThietBiPhong();
                            frm.ShowDialog();
                            break;
                        }
                    case "KHACHHANG":
                        {
                            frmKhachHang frm = new frmKhachHang();
                            frm.ShowDialog();
                            break;
                        }
                    case "DOAN":
                        {
                            frmDatPhong frm = new frmDatPhong();
                            frm.ShowDialog();
                            break;
                        }
                }
            
            }
        }

        private void popupMenu1_Popup(object sender, EventArgs e)
        {
            Point point = gControl.PointToClient(Control.MousePosition);
            RibbonHitInfo hitInfo = gControl.CalcHitInfo(point);
            if( hitInfo.InGalleryItem || hitInfo.HitTest == RibbonHitTest.GalleryImage)
            {
                item = hitInfo.GalleryItem;
            } 

        }

        private void btnDatPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_phong.checkEmpty(int.Parse(item.Value.ToString())))
            {
                MessageBox.Show("Phòng đã được đặt. Vui lòng chọn phòng khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frmDatPhongDon frm = new frmDatPhongDon();
            frm._idPhong = int.Parse(item.Value.ToString());
            frm._them = true;
            frm.ShowDialog();
        }

        private void gControl_Click(object sender, EventArgs e)
        {

        }

        private void btnSPDV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Chức năng đang bảo trì", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            /*frmDatPhongDon frm = new frmDatPhongDon();
            frm._idPhong = int.Parse(item.Value.ToString());
            frm._them = false;
            frm.ShowDialog();*/
        }

        

        private void btnThanhToan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!_phong.checkEmpty(int.Parse(item.Value.ToString())))
            {
                MessageBox.Show("Phòng chưa được đặt nên không thể thanh toán được. Vui lòng chọn phòng đã được đặt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frmDatPhongDon frm = new frmDatPhongDon();
            frm._idPhong = int.Parse(item.Value.ToString());
            frm._them = false;
            frm.ShowDialog();
        }

        private void btnChuyenPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!_phong.checkEmpty(int.Parse(item.Value.ToString())))
            {
                MessageBox.Show("Phòng chưa được đặt nên không được phép chuyển. Vui lòng chọn phòng đã được đặt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frmChuyenPhong frm = new frmChuyenPhong();
            frm._idPhong = int.Parse(item.Value.ToString());
            frm.ShowDialog();
        }
    }
}
