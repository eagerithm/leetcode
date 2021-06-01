export default function assertEqual(actual, expected) {
  actual = JSON.stringify(actual);
  expected = JSON.stringify(expected);
  actual === expected
    ? console.log("passed")
    : console.log("FAILD!! EXPECTED " + expected + "BUT GOT " + actual);
}
