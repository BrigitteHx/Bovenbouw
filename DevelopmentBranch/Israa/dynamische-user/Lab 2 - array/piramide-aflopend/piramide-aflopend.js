  // Functie om aflopende piramide te genereren
function generatePyramid() {
  const numRows = parseInt(document.getElementById('numRows').value);
  let pyramid = '';
  for (let i = numRows; i >= 1; i--) {
    for (let j = 1; j <= i; j++) {
      pyramid += j + ' ';
    }
    pyramid += '\n';
  }
  document.getElementById('pyramid').textContent = pyramid;
}
