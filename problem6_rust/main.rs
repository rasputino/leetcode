fn main() {
    println!("Hello, world!");

    let result = convert("PAYPALISHIRING".to_string(), 3);
    assert_eq!(result, "PAHNAPLSIIGYIR");

    let result = convert("PAYPALISHIRING".to_string(), 4);
    assert_eq!(result, "PINALSIGYAHRPI");

    let result = convert("ABCD".to_string(), 3);
    assert_eq!(result, "ABDC");

}


    pub fn convert(s: String, num_rows: i32) -> String {
        
        let mut down = true;
        let mut index = 0;
        let chars:Vec<char> = s.chars().collect();
        let mut matrix = vec![];
        while index < s.len()
        {
            if down
            {
                let mut col:Vec<char> = vec![];
                for _i in 0..num_rows
                {
                    if index < s.len()
                    {
                        col.push(chars[index]);
                        index = index + 1;
                    }
                }
                matrix.push(col);
                down = false;
            }
            else
            {
                let mut col:Vec<char> = vec![];
                for i in 0..num_rows
                {
                    if i != 0 && i < num_rows - 1 && index < s.len()
                    {
                        col.push(chars[index]);
                        index = index + 1;
                    }
                    else //if index < s.len()
                    {
                        col.push(' ');
                    }

                }
                let colr = col.into_iter().rev().collect();
                matrix.push(colr);
                down = true;
            }
        }

        let mut result:Vec<char> = vec![];
        for r in 0..num_rows as usize
        {
            for c in 0..matrix.len()
            {
                if r < matrix[c].len() && matrix[c][r] != ' '
                {
                    result.push(matrix[c][r]);
                }
            }
        }

        return result.into_iter().collect();

    }
