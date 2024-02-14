fn main() {
    // let result = longest_palindrome("babad".to_string());
    // println!("{}", result);

    // let result = longest_palindrome("cbbd".to_string());
    // println!("{}", result);

    // let result = longest_palindrome("cbbda".to_string());
    // println!("{}", result);

    // let result = longest_palindrome("bb".to_string());
    // println!("{}", result);

    let result = longest_palindrome("ccc".to_string());
    println!("{}", result);
}

pub fn longest_palindrome(s: String) -> String {
    
    if s.len() <= 1
    {
        return s;
    }

    let letters: Vec<char> = s.chars().collect();

    let mut right_index:usize = 0;
    let mut left_index:usize = 0;
    for i in 0..letters.len()
    {
        let max_distance = if i < letters.len() - 1 - i { i } else { letters.len() - 1 - i };
        for j in 0..max_distance
        {
            if letters[i-j] != letters[i+j]
            {
                break;
            }

            if (i+j) - (i-j) > right_index - left_index
            {
                left_index = i-j;
                right_index = i+j;
            }
        }

        for j in 0..max_distance+1
        {
            if i+j+1 >= letters.len() || letters[i-j] != letters[i+j+1]
            {
                break;
            }

            if (i+j+1) - (i-j) > right_index - left_index
            {
                left_index = i-j;
                right_index = i+j+1;
            }
        }
    }

    return letters[left_index..right_index+1].into_iter().collect();
}

