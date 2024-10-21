const express = require('express');
const { createProxyMiddleware } = require('http-proxy-middleware');
const app = express();
const port = 3000;

// Proxy middleware para redirecionar a rota /api para o back end (porta 5000, por exemplo)
app.use('/api', createProxyMiddleware({
  target: 'http://100.100.193.67:8080',
  changeOrigin: true,
  pathRewrite: {
    '^/api': '/', // Remove a parte /api da URL antes de enviar ao backend
  },
}));

// Proxy middleware para redirecionar a rota /web para o front end (porta 4200)
app.use('/', createProxyMiddleware({
  target: 'http://100.100.193.67:4200',
  changeOrigin: true,
}));

app.listen(port, () => {
  console.log(`Proxy server is running on http://localhost:${port}`);
});
