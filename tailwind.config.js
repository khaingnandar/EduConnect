/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    './Views/**/*.cshtml',
    './Pages/**/*.cshtml',
    './wwwroot/js/**/*.js',
    './**/*.html'
  ],
  safelist: [
    'bg-white',
    'bg-pink-100',
    'bg-pink-200',
    'bg-pink-500',
    'text-white',
    'text-pink-500'
  ],
  theme: {
    extend: {},
  },
  plugins: [],
}