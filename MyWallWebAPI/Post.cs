﻿namespace MyWallWebAPI {
    public class Post //Entidade POST
    {
        //Atributos da entidade
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public DateTime Data { get; set; }
    }
}
