from flask import Flask, render_template_string

app = Flask(__name__)

corpo_email = """
    <!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title></title>
</head>
<style>
    body {
        font-family: Arial, sans-serif;
        background-color: #f4f4f4;
        margin: 0;
        padding: 0;
      }
      .email-container {
        max-width: 600px;
        margin: auto;
        background-color: #ffffff;
        padding: 20px;
        border-radius: 8px;
        box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
      }
      .header {
        text-align: center;
        background-color: #014471;
        color: white;
        padding: 10px 0;
        border-radius: 8px 8px 0 0;
      }
      .logo{
        flex-direction: row;
        display: flex;
      }
      
      .header h1 {
        display: flex;
        flex-direction: row;
        justify-content: center;
        align-items: center;
      }
      
      .content {
        padding: 20px;
      }
      .content h2 {
        color: #333;
      }
      .content p {
        color: #555;
        line-height: 1.6;
      }
      
      .footer {
        text-align: center;
        background-color: #014471;
        color: white;
        padding: 10px 0;
        border-radius: 0 0 8px 8px;
      }
      
</style>
<body>
    <div class="email-container">
        <div class="header">
            <h1> <img src="/assets/logo_unifenas.png" alt="Logo Odon Track" class="logo"> ODONTRACK </h1> 
        </div>
        <div class="content">
            <h2>Olá, !</h2>
            <p>
                Este é o seu código de verificação:
            </p>
            <p>
                
            </p>
            <p>
                Se não foi você que o requisitou, contate a Unifenas pelo número: 
            </p>

        
        </div>
        <div class="footer">
            <p>
                <img src="/Odon.Track.Python.API/assets/logo_unifenas.png" alt="Logo Odon Track">
            </p>
        </div>
    </div>
</body>
</html>
    """

@app.route('/')
def index():
    return render_template_string(corpo_email)

if __name__ == '__main__':
    app.run(debug=True)