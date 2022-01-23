public string pasta = "local onde deseja salvar os arquivos";
string title = "titulo do arquivo;

WebClient client = new WebClient();

client.DownloadFile(new Uri($"https://img.youtube.com/vi/Kt7GwKAhlRQ/maxresdefault.jpg"), pasta + "//" + title + ".jpg");
client.DownloadFileAsync(new Uri($"https://img.youtube.com/vi/Kt7GwKAhlRQ/maxresdefault.jpg"), pasta + "//" + title + ".jpg");

//pode ser usado para arquivos em gerais, necessita apenas mudar extenção 
//o "client.DownloadFile" trava o aplicativo e não funciona em caso de tempo de resposta alto
//o "client.DownloadFileAsync" não trava o aplicativo e espera a resposta do arquivo, recomendo sempre o Async 
