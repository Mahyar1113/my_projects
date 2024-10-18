// Define a Line class
class Line {
    constructor(startX, startY, endX, endY) {
      this.startX = startX;
      this.startY = startY;
      this.endX = endX;
      this.endY = endY;
    }
  // Calculate the length of the line using the distance formula
    calculateLength() {
      const deltaX = this.endX - this.startX;
      const deltaY = this.endY - this.startY;
      const length = Math.sqrt(deltaX ** 2 + deltaY ** 2);
      return length;
    }
  }
// Function to calculate the line length and display it to the user
  function calculateLineLength() {
    const startX = parseInt(document.getElementById('startX').value);
    const startY = parseInt(document.getElementById('startY').value);
    const endX = parseInt(document.getElementById('endX').value);
    const endY = parseInt(document.getElementById('endY').value);
    
// Create a new instance of the Line class with the retrieved coordinates
    const line = new Line(startX, startY, endX, endY);
    // Call the calculateLength() method on the line object to calculate the length of the line
    const length = line.calculateLength();

    document.getElementById('result').textContent = `The length of the line is: ${length}`;
  }s