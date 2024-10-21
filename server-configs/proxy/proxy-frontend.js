const http = require('http');
const httpProxy = require('http-proxy');

const proxy = httpProxy.createProxyServer({});

const server = http.createServer((req, res) => {
  // Encaminhar a solicitação para o servidor interno
  proxy.web(req, res, { target: 'http://192.168.49.2:30000' });
});

server.listen(4200, '100.100.193.67', () => {
  console.log('Servidor proxy rodando em http://100.100.193.67:4200');
});
