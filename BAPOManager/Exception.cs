using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BAPOManager
{
    class Exception
    {
    }
}

public class CapNhapPhieuNhapException : Exception
{
    public string Mess { get; set; }
    public CapNhapPhieuNhapException() { }
}

public class XoaPhieuNhapException : Exception
{
    public string Mess { get; set; }
    public XoaPhieuNhapException() { }
}