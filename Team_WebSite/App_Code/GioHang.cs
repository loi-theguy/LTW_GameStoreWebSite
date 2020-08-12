using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for GioHang
/// </summary>
public class GioHang
{
    public static List<Game> list=new List<Game>();
	public GioHang()
	{
	}
    public GioHang(List<Game> list)
    {
        GioHang.list = list;
    }
    public static double tinhTongTien()
    { 
        double t=0;
        for (int i = 0; i < list.Count; i++)
            t += list[i].Gia;
        return t;
    }
}