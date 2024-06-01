from flask import Flask, jsonify, request, send_file
from Functions import enviarEmail

app = Flask(__name__)

@app.route('/EnviarEmail', methods=['POST'])
def EnviarCodigo():
    if request.method == 'POST':
        dados = request.json
        if dados:
            codigo = dados.get('codigo')
            nomeUsuario = dados.get('nomeUsuario')
            numeroUnifenas = dados.get('numeroUnifenas')
            email = dados.get('email')
            enviarEmail(nomeUsuario,codigo,numeroUnifenas,email)
            return jsonify({'id': codigo},{'sucesso:': 'true'})
        else:
            return jsonify({'erro':'valores não recebidos'})
    else:
        return jsonify({'erro':'método não aceito'})

@app.route('/LogoOdonTrack')
def get_logo_odontrack():
    image_path = './assets/logo_odon_track.png'
    return send_file(image_path, mimetype='image/png')

if __name__ == '__main__':
    app.run(host='0.0.0.0', port=5000)