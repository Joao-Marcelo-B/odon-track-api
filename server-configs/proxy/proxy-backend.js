const http = require('http');
const httpProxy = require('http-proxy');

const proxy = httpProxy.createProxyServer({});

const server = http.createServer((req, res) => {
  // Encaminhar a solicitação para o servidor interno
  proxy.web(req, res, { target: 'http://192.168.49.2:30001' });
});

server.listen(8080, '100.100.193.67', () => {
  console.log('Servidor proxy rodando em http://100.100.193.67:8080...');
});
