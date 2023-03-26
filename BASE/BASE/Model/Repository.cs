using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BASE.Model
{
    class Repository
    {
        private SQLiteConnection con;
        private static Repository instancia;
        public string EstadoMensaje;


        public static Repository Instancia
        {
            get {
                if (instancia == null) 
                    throw new Exception("Debe llamar al inicializador, acción detenida");
                return instancia;
            }
        }
        
        public static void Inicializador(String filename)
        {
            if (filename == null) {throw new ArgumentException();}
            if (instancia != null) {instancia.con.Close();}
            instancia = new Repository(filename);
        }
        private Repository(String dbPath)
        {
            con = new SQLiteConnection(dbPath);
            con.CreateTable<db>();
        }
        public int AddNewDB(string description, int importancia)
        {
            int result = 0;
            try
            {
                result = con.Insert(new db
                {Description = description, Importancia = importancia});
                EstadoMensaje = string.Format("Cantidad filas : {0}", result);
            }
            catch (Exception e) { EstadoMensaje = e.Message; }
            return result;
        }
        public IEnumerable<db> GetAllDB()
        {
            try {return con.Table<db>();}
            catch (Exception e) {EstadoMensaje = e.Message;}
            return Enumerable.Empty<db>();
        }
        public int DeleteDB(int id)
        {
            int result = 0;
            try
            {
                con.Delete<db>(id);
                EstadoMensaje = string.Format("Se borra el registro {0}", id);
            }
            catch (Exception e){ EstadoMensaje = e.Message; }
            return result;
        }
        public int UpdateDB(int id, string description, int importancia)
        {
            int result = 0;
            try
            {
                result = con.Execute("UPDATE Agenda SET Description = ? Where Id = ? ", description, id);
                result = con.Execute("UPDATE Agenda SET Importancia = ? Where Id = ? ", importancia, id);
                EstadoMensaje = string.Format("Actualizado!");
            }
            catch (Exception e)
            { EstadoMensaje = e.Message; }
            return result;
        }

    }
}
