using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Game
/// </summary>
public class Game
{
    String id, tenGame;
    double gia;

    public double Gia
    {
        get { return gia; }
        set { gia = value; }
    }
    public String TenGame
    {
        get { return tenGame; }
        set { tenGame = value; }
    }
    public String ID
    {
        get{return id;}
        set { tenGame = value; }
    }
    public Game()
    {

    }
    public Game(String id, String tenGame, float gia)
    {
        this.gia = gia;
        this.tenGame = tenGame;
        this.id = id;
    }
}