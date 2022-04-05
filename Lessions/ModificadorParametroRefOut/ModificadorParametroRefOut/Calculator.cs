namespace ModificadorParametroRefOut {
    class Calculator {


        public static void TripleRef(ref int origin) {
            origin = origin * 3;
        }

        public static void TripleOut(int origin, out int triple) {
            triple = origin * 3;
        }
    }
}
