namespace ConversaoDolar {
    class ConversorDeMoeda {

        public static double CotacaoDolar;
        public static double DolarComprar;
        public static double Iof = 6.0;

        public static double DolarParaReal() {
            double total = CotacaoDolar * DolarComprar;            
            return total += total * Iof / 100;
        }
    }
}
