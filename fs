const fs = require('fs')
const data = 'npm e um gerenciador de pacotes para o Node.js';
fs.writeFile('arquivo.txt',data, (err) => {
    if (err) throw err;
    console.log('O arquivo foi criado');
})
