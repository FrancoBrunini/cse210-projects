public class Entry
{
    public DateTime Fecha { get; set; }
    public string Pregunta { get; set; }
    public string Respuesta { get; set; }

    public override string ToString()
    {
        return $"{Fecha:yyyy-MM-dd HH:mm} Pregunta: {Pregunta}\nRespuesta: {Respuesta}\n";
    }
}