const net = require('net');

// Configurar o servidor TCP para escutar no seu endereço IP da VPN
const server = net.createServer((socket) => {
  // Conectar-se ao banco de dados no Kubernetes
  const dbSocket = net.connect({ host: '192.168.0.106', port: 3006 });

  // Encaminhar os dados entre o cliente e o banco de dados
  socket.pipe(dbSocket);
  dbSocket.pipe(socket);

  // Lidar com o encerramento da conexão
  socket.on('end', () => {
    dbSocket.end();
  });

  dbSocket.on('end', () => {
    socket.end();
  });

  socket.on('error', (err) => {
    dbSocket.end();
  });

  dbSocket.on('error', (err) => {
    console.error('Erro no banco de dados:', err);
    socket.end();
  });
});

// Lidar com erros no servidor TCP
server.on('error', (err) => {
  console.error('Erro no servidor:', err);
});

// Iniciar o servidor TCP na porta desejada do seu IP da VPN
server.listen(3307, '100.81.41.26', () => {
  console.log('Servidor TCP rodando em 100.81.41.26:3307');
});
