import smtplib
from email.mime.multipart import MIMEMultipart
from email.mime.text import MIMEText
from email.mime.image import MIMEImage
from email.mime.base import MIMEBase
from email import encoders

def enviarEmail(nomeUsuario,codigo,numeroUnifenas,email):
    def send_email_with_image(smtp_server, smtp_port, sender_email, sender_password, recipient_email, subject, body, image_paths):
        msg = MIMEMultipart()
        msg['From'] = sender_email
        msg['To'] = recipient_email
        msg['Subject'] = subject

        msg.attach(MIMEText(body, 'html'))

        for i, image_path in enumerate(image_paths):
            with open(image_path, 'rb') as img_file:
                img = MIMEImage(img_file.read())
                img.add_header('Content-ID', f'<image{i}>')
                msg.attach(img)

        with smtplib.SMTP(smtp_server, smtp_port) as server:
            server.starttls()
            server.login(sender_email, sender_password)
            server.sendmail(sender_email, recipient_email, msg.as_string())

    
    SMTP_SERVER = 'smtp.gmail.com'
    SMTP_PORT = 587
    SENDER_EMAIL = 'joao.pfernandes@aluno.unifenas.br'
    SENDER_PASSWORD = 'tkjn ehup slwi sfau'
    RECIPIENT_EMAIL = email
    SUBJECT = 'Aqui está seu código'

    BODY = """
<!DOCTYPE html>
<html lang="pt-BR">
<head>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<title>UNIFENAS</title>
</head>
<body style="font-family: Arial, sans-serif;
    background-color: #f4f4f4;
    margin: 0;
    padding: 0;">

<div class="email-container" style="max-width: 600px;
    margin: auto;
    background-color: #ffffff;
    padding: 20px;
    border-radius: 8px;
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);">

    <div class="header" style="text-align: center;
    background-color: #014471;
    color: white;
    padding: 10px 0;
    border-radius: 8px 8px 0 0;">

        <h1 style="display: flex;
        flex-direction: row;
        justify-content: center;
        align-items: center;"> 

            <img src="cid:image0" style="flex-direction: row; display: flex;"> ODONTRACK 
        
        </h1> 
    </div>
    <div class="content" style="padding: 20px">
        <h2 style="color: #333;">Olá, %s!</h2>
        <p style="color: #555;line-height: 1.6;">
            Este é o seu código de verificação:
        </p>
        <b style="color: #555;line-height: 1.6; font-size: xx-large">
            %s
        </b>
        <p style="color: #555;line-height: 1.6;">
            Se não foi você que o requisitou, contate a Unifenas pelo número: %s 
        </p>

    
    </div>
    <div class="footer" style="text-align: center;
        background-color: #014471;
        color: white;
        padding: 10px 0;
        border-radius: 0 0 8px 8px;">
        <p style="color: #555;line-height: 1.6;"> <img src="cid:image1"></p>
    </div>
</div>
</body>
</html>
""" % (nomeUsuario,codigo,numeroUnifenas)
    
    IMAGE_PATHS = [
        '../Odon.Track.Python.API/assets/logo_odon_track.png',
        '../Odon.Track.Python.API/assets/logo_unifenas.png'
    ]

    send_email_with_image(SMTP_SERVER, SMTP_PORT, SENDER_EMAIL, SENDER_PASSWORD, RECIPIENT_EMAIL, SUBJECT, BODY, IMAGE_PATHS)