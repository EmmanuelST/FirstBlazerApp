using FirstBlazerApp.DAL;
using FirstBlazerApp.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstBlazerApp.BLL
{
    public class RepostitorioGenero
    {

        public static bool Guardar(Generos genero)
        {
            bool paso = false;

            Contexto db = new Contexto();

            try
            {

                db.Generos.Add(genero);
                paso = db.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }




            return paso;
        }


        public static bool Modificar(Generos genero)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(genero).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;
                

            }
            catch (Exception) { throw; }
            finally { db.Dispose(); }


            return paso;
        }


        public static bool Eliminar(int Id)
        {
            bool paso = false;

            Contexto db = new Contexto();
            
            try
            {

                Generos genero = db.Generos.Find(Id);

                if(genero != null)
                {
                    db.Entry(genero).State = EntityState.Deleted;
                    paso = db.SaveChanges() > 0;
               
                }


            }
            catch (Exception) { throw; }
            finally { db.Dispose(); }



            return paso;
        }


        public static Generos Buscar(int Id)
        {
            Generos genero = null;
            Contexto db = new Contexto();

            try
            {
                genero = db.Generos.Find(Id);



            }catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }



            return genero;
        }



        public static List<Generos> GetList()
        {
            List<Generos> lista = new List<Generos>();
            Contexto db = new Contexto();

            try
            {
                lista = db.Generos.Where(G => true).ToList();

            }
            catch (Exception) { throw; }
            finally { db.Dispose(); }


            return lista;
            
        }


    }
}
