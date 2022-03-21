const path = require("path");

module.exports = {
  entry: "./src/index.js",
  mode: "production",
  performance: {
    hints: false,
},
  devtool: "eval-source-map",
  // module: {
  //     rules: [
  //         {
  //             test: /\.tsx?$/,
  //             use: 'ts-loader',
  //             exclude: /node_modules/,
  //         },
  //     ],
  // },
  devServer: {
    static: {
      directory: path.join(__dirname, "./dist"),
    },
    hot: true,
  },
  resolve: {
    extensions: [".js"],
  },
  output: {
    filename: "bundle.js",
    path: path.resolve(__dirname, "./dist"),
  },
};
