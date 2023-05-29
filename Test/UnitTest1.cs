using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BUS;
using DAL;
using BUS.Interface;
using DTO;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void login1()
        {
            IBUS_NguoiDung busnd = new BUS_NguoiDung();
            Assert.IsTrue(busnd.Login("",""));
        }

        [TestMethod]
        public void login2()
        {
            IBUS_NguoiDung busnd = new BUS_NguoiDung();
            Assert.IsTrue(busnd.Login("adlos", "1"));
        }

        [TestMethod]
        public void login3()
        {
            IBUS_NguoiDung busnd = new BUS_NguoiDung();
            Assert.IsTrue(busnd.Login("admin", "admin"));
        }

        [TestMethod]
        public void checktaikhoan()
        {
            IBUS_NguoiDung busnd= new BUS_NguoiDung();
            Assert.AreEqual(-1, busnd.CheckTaiKhoan("long"));
        }

        [TestMethod]
        public void checkmand()
        {
            IBUS_NguoiDung busnd = new BUS_NguoiDung();
            Assert.AreEqual(-1, busnd.CheckMaND("ad01"));
        }

        [TestMethod]
        public void InsertKH()
        {
            DTO_KhachHang dtokh = new DTO_KhachHang();
            IBUS_KhachHang buskh = new BUS_KhachHang();
            Assert.Equals(-1, buskh.Insert(dtokh));
        }

        [TestMethod]
        public void UpdateKH()
        {
            DTO_KhachHang dtokh = new DTO_KhachHang();
            IBUS_KhachHang buskh = new BUS_KhachHang();
            Assert.Equals(-1, buskh.Update(dtokh));
        }

        [TestMethod]
        public void DeleteKH()
        {
            DTO_KhachHang dtokh = new DTO_KhachHang();
            IBUS_KhachHang buskh = new BUS_KhachHang();
            Assert.Equals(-1, buskh.Delete("kh01"));
        }
    }
}
