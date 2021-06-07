/**
 * @param {string} haystack
 * @param {string} needle
 * @return {number}
 */

// 해당 문제는 indexOf를 생각하면 편함.

const strStr = (haystack, needle) => {
  // needle이 없거나 길이가 0일때 0을 반환
  // 본문: we will return 0 when needle is an empty string.
  if (!needle.length) return 0;

  // haystack만큼 i회 반복
  for (let i = 0; i < haystack.length; i++) {
    // haystack의 문자열에서 i와 i + needle.length 사이 만큼 substring
    // 여기서 substring시 he, ll, o 으로 출력 되는데 이 값과 needle의 값을 비교하면 됨.
    if (haystack.substring(i, i + needle.length) === needle) {
      return i;
    }
  }

  // haystack의 검색결과가 없을때 -1 반환
  // 본문: Return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
  return -1;
};

// 가장 간단하면서 광탈하기 좋은 방법...
// const strStr = (haystack, needle) => {
//     return haystack.indexOf(needle)
// }
