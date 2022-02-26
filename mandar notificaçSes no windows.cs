using Microsoft.Toolkit.Uwp.Notifications;

new ToastContentBuilder()

           .AddText("titulo principal")
           .AddText(title + "subtitulo")
           .AddHeroImage(new Uri("link imagem"))
           .Show();

//limpar notificações, recomendo ao fechar o programa 
ToastNotificationManagerCompat.History.Clear();