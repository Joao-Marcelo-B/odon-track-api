const express = require('express');
const { createProxyMiddleware } = require('http-proxy-middleware');
const app = express();
const port = 3000;

// Proxy middleware para redirecionar a rota /api para o back end (porta 5000, por exemplo)
app.use('/api', createProxyMiddleware({
  target: 'http://192.168.0.106:8080',
  changeOrigin: true,
  pathRewrite: {
    '^/api': '/', // Remove a parte /api da URL antes de enviar ao backend
  },
}));

app.use('/api', createProxyMiddleware({
  target: 'http://192.168.0.106:5001',
  changeOrigin: true,
  pathRewrite: {
    '^/ai': '/', // Remove a parte /api da URL antes de enviar ao backend
  },
}));

// Proxy middleware para redirecionar a rota /web para o front end (porta 4200)
app.use('/', createProxyMiddleware({
  target: 'http://192.168.0.106:4200',
  changeOrigin: true,
}));

app.listen(port, () => {
  console.log(`Proxy server is running on http://localhost:${port}`);
});
