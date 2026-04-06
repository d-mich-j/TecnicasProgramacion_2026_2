namespace MonitoreoDrones.Utiidades {
    public static class UtilidadesCalculoDron 
    {
        public static double EstimarConsumoBateria(double distancia ) {
            return distancia * 2.5;
        }
        public static double EstimarConsumoBatera(double nivelBateria) {
            return nivelBateria / 2.5;
        }
    }
}
