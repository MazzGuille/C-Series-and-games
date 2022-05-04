namespace Interface
{
    public interface IEntregable
    {
        public var Prestado();
        public var Entregar{get; set;}

        public var Devolver { get; set; }

        public var IsEntregado();
        

    }
}


