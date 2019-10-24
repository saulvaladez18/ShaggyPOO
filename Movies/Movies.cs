using System;
	using System.Collections.Generic;
	
	namespace peliculaSaulValadez
	{
	    class Pelicula
	    {
	        
	        private String Titulo;
	        private Int16 Año;
	        private string Pais;
	        private string Director;
	
	        
	        public void SetTitulo(string Titulo)
	        {
	            this.Titulo = Titulo;
	        } 
	        public string GetTitulo()
	        {
	            return this.Titulo;
	        }
	        public void SetAño(Int16 Año)
	        {
	            this.Año = Año;
	        } 
	        public Int16 GetAño()
	        {
	            return this.Año;
	        }
              public void Setpais(string Pais)
	        {
	            this.Pais = Pais;
	        } 
	        public string Getpais()
	        {
	            return this.Pais;
	        }
	        public void SetDirector(string Director)
	        {
	            this.Director = Director;
	        } 
	        public String GetDirector()
	        {
	            return this.Director;
	        }
	
	        public Pelicula()
	        {
	
	        }
	        public Pelicula(String Titulo, Int16 Año,String Pais,String Director)
	        {
	            this.Titulo = Titulo;
	            this.Año = Año;
                this.Pais=Pais;
                this.Director=Director;
	        }
	
	        public void imprime()
	        {
	            Console.WriteLine("Titulo: {0}\nAño: {1}\nPais:{2}\nDirector:{3}\n", this.Titulo, this.Año,this.Pais,this.Director);
	        }
	    }
	    class Program
	    {
	        static void Main(String[] args)
	        {
	            Pelicula p1 = new Pelicula();
	            p1.SetTitulo("Get Out");
	            p1.SetAño(2017);
                p1.Setpais("United States");
                p1.SetDirector("Jordon Peele");
	
	            p1.imprime();
	            
	            Pelicula p2 = new Pelicula();
	            p2.SetTitulo("IT");
	            p2.SetAño(2017);
                p2.Setpais("United States");
                p2.SetDirector("Andres Muschietti");

	
	            p2.imprime();
	            
	
	            
	            List<Pelicula> peliculas = new List<Pelicula>();
	            peliculas.Add(new Pelicula("Thor: Ragnarok", 2017,"United States","Stan Lee"));
	            peliculas.Add(new Pelicula("Spider-Man Homecoming",2017,"United States","Jon Watts" ));
	            peliculas.Add(new Pelicula("Coco",2017,"United States","Lee Unkrich"));
              
	
	            
	            foreach(Pelicula p in peliculas)
	            {
	                p.imprime();
	            }
	            
	        }
	    }
	}
