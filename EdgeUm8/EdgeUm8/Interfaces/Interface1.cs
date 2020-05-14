using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace EdgeUm8.Interfaces
{
    public interface ISQLiteInterface

    {
        SQLiteConnection GetSQLiteConnection();

    }
}
