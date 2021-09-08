var isSumEqual = function (firstWord, secondWord, targetWord) {
  let testValue = [firstWord, secondWord, targetWord];
  for (let i = 0; i < testValue.length; i++) {
    let newWord = "0";
    testValue[i].split("").forEach((alphabet) => {
      if (alphabet === "a") newWord += "0";
      if (alphabet === "b") newWord += "1";
      if (alphabet === "c") newWord += "2";
    });
    testValue[i] = newWord;
  }

  return parseInt(testValue[0]) + parseInt(testValue[1]) == testValue[2]
    ? true
    : false;
};
