

// Store student marks in an array
const marks = [88, 90, 95, 99, 100];

// Arrow function to calculate total using reduce()
const calculateTotal = (arr) =>
  arr.reduce((total, mark) => total + mark, 0);

// Arrow function to calculate average
const calculateAverage = (arr) =>
  arr.length ? calculateTotal(arr) / arr.length : 0;

// Arrow function to determine pass/fail
const getResult = (average) => (average >= 50 ? "PASS ✅" : "FAIL ❌");

// Function to display detailed report
const generateReport = (marksArray) => {
  const total = calculateTotal(marksArray);
  const average = calculateAverage(marksArray);
  const result = getResult(average);

  // Using map() to format marks
  const formattedMarks = marksArray
    .map((mark, index) => `Subject ${index + 1}: ${mark}`)
    .join("\n");

  const report = `
  ===== Student Marks Report =====
  ${formattedMarks}
  
  Total Marks: ${total}
  Average Marks: ${average.toFixed(2)}
  Result: ${result}
  =================================
  `;

  console.log(report);
};

// Call the function
generateReport(marks);