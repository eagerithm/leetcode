/**
 * @param {string} s
 * @return {string}
 */
const reverseWords = (s) => {
  // 문자열을 공백 별로 split
  const splittedWords = s.split(" ");
  // 결과 반환 배열
  const result = [];

  // s가 쪼개진 만큼 반복
  for (let i = 0; i < splittedWords.length; i++) {
    if (splittedWords[splittedWords.length - (i + 1)] !== "") {
      result.push(splittedWords[splittedWords.length - (i + 1)]);
    }
  }

  // join으로 배열 합침
  return result.join(" ");
};
