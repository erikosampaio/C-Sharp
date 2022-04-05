namespace TesteComProprerties {
    internal class Cachorro {

        public string Nome { get; private set; }
        public string Raca { get; private set; }
        public int _idade;
        public int _saude;
        
        public Cachorro() {
            Nome = "Chitara";
            Raca = "RND";
        }

        public int Idade { 
            get { return _idade; }
            set {
                if (value < _idade) {
                    _idade = value;
                }
            }
        }

        public int Saude {
            get { return _saude; }
            set {
                if (value > 0) {
                    _saude = value;
                }
            }
        }
    }
}
