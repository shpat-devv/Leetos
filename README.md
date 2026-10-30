# Leetos

The goal of this project is to have a collection of problems I solved from LeetCode, where I can directly create, edit, review, and test solutions.

## Barebones Idea

- Start program
- Choose option (`list`, `run`)
- View problem, output, and expected result

## Current Implementation

Currently, it works by having separate files for all the problems, which are then gathered in an object list where they can be executed.

### Features

- All problems stored inside a list
- Each problem is stored as an object
- Problem can be executed and match output against expected result
- Executed output captures runtime

### Incoming changes

- Improve CLI styling
- Store problems inside database
- Selective problem handling