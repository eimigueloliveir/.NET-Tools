using (BinaryReader reader = new BinaryReader(
            assembly.GetManifestResourceStream(@"caminho completo na solução")))
{
    var diretorio = "local para salvar o arquivo";
    using (BinaryWriter writer
        = new BinaryWriter(new FileStream(diretorio, FileMode.Create)))
    {
        long bytesLeft = reader.BaseStream.Length;
        while (bytesLeft > 0)
        {
            // 65535L is < Int32.MaxValue, so no need to test for overflow
            byte[] chunk = reader.ReadBytes((int)Math.Min(bytesLeft, 65536L));
            writer.Write(chunk);

            bytesLeft -= chunk.Length;
        }
    }
}