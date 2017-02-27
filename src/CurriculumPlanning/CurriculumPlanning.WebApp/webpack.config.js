const path = require('path');
const inputPath = path.join(__dirname, '/Scripts');
const outputPath = path.join(__dirname, '/wwwroot');

module.exports = {
  context: inputPath,
  entry: path.join(inputPath, 'index.js'),
  output: {
    path: outputPath,
    filename: 'js/bundle.js'
  },
  module: {
    loaders: [
      {
        test: /\.jsx?$/,
        exclude: /(node_modules|bower_components)/,
        loader: 'babel-loader',
        query: {
          presets: ['react', 'es2015']
        }
      }
    ]
  }
};